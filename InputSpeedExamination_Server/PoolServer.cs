using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InputSpeedExamination_Server
{
    public class PoolServer
    {

        /// <summary>
        /// 服务器
        /// 1.调用构造方法：
        ///   (1)加载参数:端口、最大活动数量
        ///    (2)启用PooledConnectionHandler线程,根据最大活动数量创建线程,并且全部启动
        ///   PooledConnectionHandler线程,读取pool池,判断池内是否为空,如果不为空,则让线程安全的读取池内的第一个,并且进行业务处理
        ///   2.开启服务
        ///    (1)将TcpListener对象初始化
        ///       (2)等待客户机的请求,调用AcceptConnections()方法
        /// 
        ///         @author layicr
        /// </summary>
        /// <summary>
        /// 最大活动数量
        /// </summary>
        /// 
        private int maxConnections;

        /// <summary>
        /// 最大活动数量
        /// </summary>
        public int MaxConnections
        {
            get { return maxConnections; }
            set { maxConnections = value; }
        }

        /// <summary>
        /// 端口
        /// </summary>
        private int port;

        /// <summary>
        /// 端口
        /// </summary>
        public int Port
        {
            get { return port; }
            set { port = value; }
        }

        /// <summary>
        /// 第几张网卡，默认为第一个，值为0
        /// </summary>
        private int addressIndex = 0;

        /// <summary>
        /// 第几张网卡，默认为第一个，值为0
        /// </summary>
        public int AddressIndex
        {
            get { return addressIndex; }
            set { addressIndex = value; }
        }

        /// <summary>
        /// 是否打开服务
        /// </summary>
        private bool reLease = false;

        /// <summary>
        /// 线程集合
        /// </summary>
        private List<Thread> listConnectionThread = new List<Thread>();

        private TcpListener listener = null;
        private TcpClient client = null;

        /// <summary>
        /// 
        /// </summary>
        public PoolServer()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="port">端口</param>
        /// <param name="maxConnections">最大活动数量</param>
        public PoolServer(int port, int maxConnections)
        {
            this.port = port;
            this.maxConnections = maxConnections;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="addressIndex">第几张网卡</param>
        /// <param name="port">端口</param>
        /// <param name="maxConnections">最大活动数量</param>
        public PoolServer(int addressIndex, int port, int maxConnections)
        {
            this.addressIndex = addressIndex;
            this.port = port;
            this.maxConnections = maxConnections;
        }

        /// <summary>
        /// 启动服务
        /// </summary>
        public void ServerStart()
        {
            this.reLease = true;
            IPHostEntry IpEntry = Dns.GetHostEntry(Dns.GetHostName()); //得到主机IP
            IPAddress iPAddress = IpEntry.AddressList[addressIndex];
            listener = new TcpListener(iPAddress, this.port);
            listener.Start();
            //开启线程
            SetUpHandlers();
            // 允许客户机连接到服务器,等待客户机请求
            AcceptConnections();
        }

        /// <summary>
        ///  停止服务
        /// </summary>
        public void ServerStop()
        {
            if (listener != null)
            {
                try
                {
                    listener.Stop();
                    listener = null;
                    //清空池数据
                    PoolConnectionHandler.pool.Clear();
                    reLease = false;
                    //让PooledConnectionHandler线程停止
                    foreach (Thread item in listConnectionThread)
                    {
                        //停止
                        item.Abort();
                    }
                    //清空
                    listConnectionThread.Clear();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        /// <summary>
        /// 允许客户机连接到服务器,等待客户机请求
        /// 1.开启一个线程
        /// </summary>
        private void AcceptConnections()
        {
            new Thread(ListenerStart).Start();
        }

        /// <summary>
        /// 允许客户机连接到服务器,等待客户机请求
        /// 2.判断当前reLease(是否启用服务)的值是否为true
        /// 如果没有启用服务,则线程关闭
        /// 如果启用服务,则开始等待客户机请求,如果受到了客户机的请求,则加入池中
        /// </summary>
        private void ListenerStart()
        {
            while (reLease)
            {
                try
                {
                    client = listener.AcceptTcpClient();
                    HandleConnection(client);
                }
                catch (Exception e)
                {
                    //
                    Console.WriteLine(e.Message);
                }
            }
        }

        /// <summary>
        /// 将请求加入池中
        /// </summary>
        /// <param name="client"></param>
        private void HandleConnection(TcpClient client)
        {
            PoolConnectionHandler.ProcessRequest(client);
        }

        /// <summary>
        ///  开启PooledConnectionHandler线程
        /// </summary>
        private void SetUpHandlers()
        {
            Thread thread = null;
            for (int i = 0; i < maxConnections; i++)
            {
                PoolConnectionHandler currentHandler = new PoolConnectionHandler();
                thread = new Thread(new ThreadStart(currentHandler.Run));
                thread.Name = "Thread(" + i + ")";
                thread.Start();
                listConnectionThread.Add(thread);
            }
        }
    }
}
