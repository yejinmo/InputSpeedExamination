using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputSpeedExamination_Server
{
    public partial class Form_Main : Form
    {

        bool AutoRemove = false;

        #region UI
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {

        }

        private delegate void AddContentDelegate(string message);

        private void AddContent(string str)
        {

            if (TextMain.InvokeRequired)
            {
                AddContentDelegate d = new AddContentDelegate(AddContent);
                TextMain.Invoke(d, new object[] { str });
            }
            else
            {
                string Update_Date = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
                string Update_Time = string.Format("{0:00}:{1:00}:{2:00}.{3:0000}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond);

                TextMain.AppendText("【" + Update_Date + " " + Update_Time + "】    " + str + Environment.NewLine);
                TextMain.ScrollToCaret();


                //TextMain.ScrollToCaret();
            }

        }

        #endregion

        #region Servere

        #region 全局变量

        /// <summary>
        /// 监听地址
        /// </summary>
        string ServerIP;

        /// <summary>
        /// 监听端口
        /// </summary>
        int ServerPort;

        /// <summary>
        /// 监听器
        /// </summary>
        TcpListener ServerListener;

        /// <summary>
        /// 是否正常退出所有接收线程
        /// </summary>
        bool IsNormalExit = false;

        /// <summary>
        /// 保存连接的所有用户
        /// </summary>
        private List<User> UserList = new List<User>();

        #endregion

        #region 监听事件及方法

        /// <summary>
        /// 开始监听
        /// </summary>
        private void StartListen()
        {
            ServerListener = new TcpListener(IPAddress.Parse(ServerIP), ServerPort);
            ServerListener.Start();
            AddContent(string.Format("开始监听 [{0}:{1}] ", ServerIP, ServerPort));
            //创建一个线程监客户端连接请求
            Thread myThread = new Thread(ListenClientConnect);
            myThread.Start();
            ButtonStart.Enabled = false;
            ButtonStop.Enabled = true;
        }

        /// <summary>
        /// 停止监听
        /// </summary>
        private void StopListen()
        {
            AddContent(string.Format("停止监听 [{0}:{1}] ", ServerIP, ServerPort));
            IsNormalExit = true;
            for (int i = UserList.Count - 1; i >= 0; i--)
            {
                RemoveUser(UserList[i]);
            }
            //通过停止监听让 myListener.AcceptTcpClient() 产生异常退出监听线程
            ServerListener.Stop();
            ButtonStart.Enabled = true;
            ButtonStop.Enabled = false;
        }

        /// <summary>
        /// 接收客户端连接
        /// </summary>
        private void ListenClientConnect()
        {
            TcpClient newClient = null;
            while (true)
            {
                try
                {
                    newClient = ServerListener.AcceptTcpClient();
                }
                catch
                {
                    //当单击‘停止监听’或者退出此窗体时 AcceptTcpClient() 会产生异常
                    //因此可以利用此异常退出循环
                    break;
                }
                //每接收一个客户端连接，就创建一个对应的线程循环接收该客户端发来的信息；
                User user = new User(newClient);
                Thread threadReceive = new Thread(ReceiveData);
                threadReceive.Start(user);
                UserList.Add(user);
                AddContent("已与 " + user.client.Client.RemoteEndPoint + " 建立连接");
                RefreshOnlineUserCount();
            }

        }

        /// <summary>
        /// 处理接收的客户端信息
        /// </summary>
        /// <param name="userState">客户端信息</param>
        private void ReceiveData(object userState)
        {
            User user = (User)userState;
            while (!user.IsClosed)
            {
                if (user.IsLocked)
                    break;
                try
                {
                    string receiveString = user.br.ReadString();
                    string[] splitString = receiveString.Split(',');
                    user.data = splitString[1];
                    switch (splitString[0])
                    {
                        case "Hello_Server":
                            Thread Thread_Get_ECardSystem = new Thread(Receive_Hello_Server);
                            Thread_Get_ECardSystem.Start(user);
                            break;
                        default:
                            AddContent("收到 [" + user.client.Client.RemoteEndPoint + "] 的未知请求");
                            RemoveUser(user);
                            break;
                    }
                }
                catch
                {
                    if (!user.IsClosed)
                        RemoveUser(user);
                    break;
                }
            }
        }

        /// <summary>
        /// 移除用户
        /// </summary>
        /// <param name="user">指定要移除的用户</param>
        private void RemoveUser(User user)
        {
            AddContent("已与 " + user.client.Client.RemoteEndPoint + " 断开连接");
            UserList.Remove(user);
            user.Close();
            RefreshOnlineUserCount();
        }

        private delegate void RefreshOnlineUserCountDelegate(string message);

        /// <summary>
        /// 刷新当前连接数
        /// </summary>
        private void RefreshOnlineUserCount(string str = "")
        {
            str = UserList.Count.ToString();

            if (TextCount.InvokeRequired)
            {
                RefreshOnlineUserCountDelegate d = new RefreshOnlineUserCountDelegate(RefreshOnlineUserCount);
                TextCount.Invoke(d, new object[] { str });
            }
            else
            {
                TextCount.Text = str;
                //TextMain.ScrollToCaret();
            }


        }

        /// <summary>
        /// 发送 message 给 user
        /// </summary>
        /// <param name="user">指定发给哪个用户</param>
        /// <param name="message">信息内容</param>
        private void SendToClient(User user, string message)
        {
            try
            {
                //将字符串写入网络流，此方法会自动附加字符串长度前缀
                user.bw.Write(message);
                user.bw.Flush();
            }
            catch
            {

            }
        }

        #endregion

        #endregion

        #region 响应事件

        private void Receive_Hello_Server(object obj)
        {
            User user = (User)obj;
            string data = user.data;
            AddContent("收到 [" + user.client.Client.RemoteEndPoint + "] 请求服务器响应");
            SendToClient(user, "Hello_Client");
            AddContent("已向 [" + user.client.Client.RemoteEndPoint + "] 发送服务器响应");
            if(AutoRemove)
                RemoveUser(user);
        }

        #endregion

    }
}
