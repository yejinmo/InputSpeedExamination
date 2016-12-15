using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Threading;
using System.IO;

namespace InputSpeedExamination
{
    public partial class Form_Main : MaterialForm
    {

        #region User Information

        /// <summary>
        /// 用户信息
        /// </summary>
        static class UserInformation
        {

            /// <summary>
            /// 系
            /// </summary>
            public static string Department = string.Empty;
            /// <summary>
            /// 专业
            /// </summary>
            public static string Major = string.Empty;
            /// <summary>
            /// 班级
            /// </summary>
            public static string Class = string.Empty;
            /// <summary>
            /// 姓名
            /// </summary>
            public static string Name = string.Empty;
            /// <summary>
            /// 学号
            /// </summary>
            public static string Number = string.Empty;
            /// <summary>
            /// 密码
            /// </summary>
            public static string Password = string.Empty;
            /// <summary>
            /// 内容ID
            /// </summary>
            public static string ContentID = string.Empty;
            /// <summary>
            /// 内容标题
            /// </summary>
            public static string ContentTitle = string.Empty;
            /// <summary>
            /// 当前GUID
            /// </summary>
            public static string GUID = string.Empty;

            /// <summary>
            /// 考场ID
            /// </summary>
            public static string ExamRoomID = string.Empty;
            /// <summary>
            /// 考场标题
            /// </summary>
            public static string ExamRoomTitle = string.Empty;
            /// <summary>
            /// 批次ID
            /// </summary>
            public static string BatchID = string.Empty;
            /// <summary>
            /// 批次标题
            /// </summary>
            public static string BatchTitle = string.Empty;

            /// <summary>
            /// 试题MD5
            /// </summary>
            public static string ContentMD5 = string.Empty;

            private static bool onLine = false;
            /// <summary>
            /// 在线状态
            /// </summary>
            public static bool OnLine
            {
                get
                {
                    return onLine;
                }

                set
                {
                    onLine = value;
                    OnLineStatsChange(value);
                }
            }

            /// <summary>
            /// 测试模式
            /// </summary>
            public static bool OnLineExamination = false;

            public delegate void OnLineChange(bool OnLine);
            public static OnLineChange OnLineStatsChange;
        }

        private void OnLineStatsChange(bool OnLine)
        {
            Invoke((EventHandler)delegate
            {
                if (OnLine)
                {
                    Label_UserName.Text = string.Format("{0}[{1}]   | ", UserInformation.Name, UserInformation.Number);
                    LinkLabel_LoginOrOut.Text = "注销";
                }
                else
                {
                    Label_UserName.Text = "离线模式   | ";
                    LinkLabel_LoginOrOut.Text = "登录";
                }
                Label_UserName.Left = 
                LinkLabel_LoginOrOut.Left - Label_UserName.Width;
            });
        }

        private void LinkLabel_LoginOrOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (UserInformation.OnLine)
            {
                UserInformation.OnLine = false;
            }
            TabControl_Main.SelectedTab = TabPage_Select;
        }

        #endregion

        #region Load

        public Form_Main()
        {
            new Thread(new ThreadStart(delegate
            {
                Form_Load frmLoading = new Form_Load();
                Shown += delegate
                {
                    frmLoading.Invoke(new EventHandler(frmLoading.KillMe));
                };
                Application.Run(frmLoading);
            })).Start();
            Thread.Sleep(1500);
            InitializeComponent();
            Thread.Sleep(1500);
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            RunCmd("RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 8");
            NeedCenterControlList.Add(new NeedCenterControl(Panel_Main_UserInformation, NeedCenterControlStyle.Both));
            NeedCenterControlList.Add(new NeedCenterControl(Panel_Login, NeedCenterControlStyle.Both));
            NeedCenterControlList.Add(new NeedCenterControl(Panel_Result, NeedCenterControlStyle.Both));
            WebView_Select_BG.ScriptErrorsSuppressed = true;
            WebView_Select_BG.Navigate(Environment.CurrentDirectory + @"\sources\web\main\index.html");
            UserInformation.OnLineStatsChange = OnLineStatsChange;
            UserInformation.OnLine = false;
            Form_Main_Resize(sender, e);
            Focus();
            BringToFront();
            Focus();
            BringToFront();
        }

        void RunCmd(string cmd)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "cmd.exe";
            // 关闭Shell的使用
            p.StartInfo.UseShellExecute = false;
            // 重定向标准输入
            p.StartInfo.RedirectStandardInput = true;
            // 重定向标准输出
            p.StartInfo.RedirectStandardOutput = true;
            //重定向错误输出
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            p.StandardInput.WriteLine(cmd);
            p.StandardInput.WriteLine("exit");
        }

        DataBase db = new DataBase();

        #endregion

        #region UI

        private struct NeedCenterControl
        {
            public NeedCenterControl(Control c, NeedCenterControlStyle n)
            {
                control = c;
                style = n;
            }
            public Control control;
            public NeedCenterControlStyle style;
        }

        private enum NeedCenterControlStyle
        {
            /// <summary>
            /// 水平居中
            /// </summary>
            Horizontal,
            /// <summary>
            /// 垂直居中
            /// </summary>
            Vertical,
            /// <summary>
            /// 水平垂直居中
            /// </summary>
            Both
        }

        List<NeedCenterControl> NeedCenterControlList = new List<NeedCenterControl>();

        private void Form_Main_Resize(object sender, EventArgs e)
        {
            foreach (var c in NeedCenterControlList)
                SetControlCenter(c.control, c.style);
            if (!OnResize && TabControl_Main.SelectedTab == TabPage_Select)
                WebView_Select_BG.Refresh();
        }

        private void SetControlCenter(Control c, NeedCenterControlStyle style)
        {
            try
            {
                if (style == NeedCenterControlStyle.Horizontal || style == NeedCenterControlStyle.Both)
                    c.Left = (c.Parent.Width - c.Width) / 2;
                if (style == NeedCenterControlStyle.Vertical  || style == NeedCenterControlStyle.Both)
                    c.Top = (c.Parent.Height - c.Height) / 2;
            }
            catch { }
        }

        bool OnResize = false;

        private void Form_Main_ResizeBegin(object sender, EventArgs e)
        {
            OnResize = true;
        }

        private void Form_Main_ResizeEnd(object sender, EventArgs e)
        {
            OnResize = false;
            if (!OnResize && TabControl_Main.SelectedTab == TabPage_Select)
                WebView_Select_BG.Refresh();
        }

        #endregion

        #region Select

        private void Button_About_Click(object sender, EventArgs e)
        {
            new Form_About().ShowDialog();
        }

        private void FlatButton_Select_OffLine_MouseMove(object sender, MouseEventArgs e)
        {
            //WebView_Select_BG.mouse
        }

        private void FlatButton_Select_OffLine_Click(object sender, EventArgs e)
        {
            if (ProcessBar_Login.Visible)
                return;
            UserInformation.OnLine = false;
            Button_SelectText_Import.Visible = true;
            Thread ThreadLoadExaminationList = new Thread(new ThreadStart(LoadExaminationList));
            ThreadLoadExaminationList.Start();
        }

        private void Button_Main_Back_Click(object sender, EventArgs e)
        {
            TabControl_Main.SelectedTab = TabPage_Select;
        }

        #endregion

        #region Examination

        private void Examination_TextLine_1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Stats_Char_Current_Total == Stats_Char_Total)
                return;
            if (Input_Status == Input_Status_Enum.SystemUpdate || Input_Status == Input_Status_Enum.PauseAndSystemUpdate)
                return;
            if (Input_Status == Input_Status_Enum.Pause)
                Input_Status = Input_Status_Enum.Input;
            if (e.KeyCode == Keys.Back && Examination_TextLine_1.Text.Length == 0)
                LoadPreviousExaminationPage();
            if (Examination_TextLine_1.Text.Length == Examination_TextLine_1.BindingLabel.TextString.Length && e.KeyCode != Keys.Back)
                Examination_TextLine_2.Focus();
        }

        private void Examination_TextLine_2_KeyDown(object sender, KeyEventArgs e)
        {
            if (Stats_Char_Current_Total == Stats_Char_Total)
                return;
            if (Input_Status == Input_Status_Enum.SystemUpdate || Input_Status == Input_Status_Enum.PauseAndSystemUpdate)
                return;
            if (Input_Status == Input_Status_Enum.Pause)
                Input_Status = Input_Status_Enum.Input;
            if (e.KeyCode == Keys.Back && Examination_TextLine_2.Text.Length == 0)
                Examination_TextLine_1.Focus();
            if (Examination_TextLine_2.Text.Length == Examination_TextLine_2.BindingLabel.TextString.Length && e.KeyCode != Keys.Back)
                Examination_TextLine_3.Focus();
        }

        private void Examination_TextLine_3_KeyDown(object sender, KeyEventArgs e)
        {
            if (Stats_Char_Current_Total == Stats_Char_Total)
                return;
            if (Input_Status == Input_Status_Enum.SystemUpdate || Input_Status == Input_Status_Enum.PauseAndSystemUpdate)
                return;
            if (Input_Status == Input_Status_Enum.Pause)
                Input_Status = Input_Status_Enum.Input;
            if (e.KeyCode == Keys.Back && Examination_TextLine_3.Text.Length == 0)
                Examination_TextLine_2.Focus();
            if (Examination_TextLine_3.Text.Length == Examination_TextLine_3.BindingLabel.TextString.Length && e.KeyCode != Keys.Back)
                Examination_TextLine_4.Focus();
        }

        private void Examination_TextLine_4_KeyDown(object sender, KeyEventArgs e)
        {
            if (Stats_Char_Current_Total == Stats_Char_Total)
                return;
            if (Input_Status == Input_Status_Enum.SystemUpdate || Input_Status == Input_Status_Enum.PauseAndSystemUpdate)
                return;
            if (Input_Status == Input_Status_Enum.Pause)
                Input_Status = Input_Status_Enum.Input;
            if (e.KeyCode == Keys.Back && Examination_TextLine_4.Text.Length == 0)
                Examination_TextLine_3.Focus();
            if (Examination_TextLine_4.Text.Length == Examination_TextLine_4.BindingLabel.TextString.Length && e.KeyCode != Keys.Back)
                Examination_TextLine_5.Focus();
        }

        private void Examination_TextLine_5_KeyDown(object sender, KeyEventArgs e)
        {
            if (Stats_Char_Current_Total == Stats_Char_Total)
                return;
            if (Input_Status == Input_Status_Enum.SystemUpdate || Input_Status == Input_Status_Enum.PauseAndSystemUpdate)
                return;
            if (Input_Status == Input_Status_Enum.Pause)
                Input_Status = Input_Status_Enum.Input;
            if (e.KeyCode == Keys.Back && Examination_TextLine_5.Text.Length == 0)
                Examination_TextLine_4.Focus();
            if (Examination_TextLine_5.Text.Length == Examination_TextLine_5.BindingLabel.TextString.Length && e.KeyCode != Keys.Back)
                LoadNextExaminationPage();
        }

        private void Examination_TextLine_1_TextChanged(object sender, EventArgs e)
        {
            if (Input_Status == Input_Status_Enum.SystemUpdate || Input_Status == Input_Status_Enum.PauseAndSystemUpdate)
                return;
            if (Input_Status == Input_Status_Enum.Pause)
                Input_Status = Input_Status_Enum.Input;
            if (Examination_TextLine_1.Text.Length == Examination_TextLine_1.BindingLabel.TextString.Length)
                Examination_TextLine_2.Focus();
            if (Input_Status == Input_Status_Enum.Input)
                UpdateStats();
        }

        private void Examination_TextLine_2_TextChanged(object sender, EventArgs e)
        {
            if (Input_Status == Input_Status_Enum.SystemUpdate || Input_Status == Input_Status_Enum.PauseAndSystemUpdate)
                return;
            if (Input_Status == Input_Status_Enum.Pause)
                Input_Status = Input_Status_Enum.Input;
            if (Examination_TextLine_2.Text.Length == Examination_TextLine_2.BindingLabel.TextString.Length)
                Examination_TextLine_3.Focus();
            if (Input_Status == Input_Status_Enum.Input)
                UpdateStats();
        }

        private void Examination_TextLine_3_TextChanged(object sender, EventArgs e)
        {
            if (Input_Status == Input_Status_Enum.SystemUpdate || Input_Status == Input_Status_Enum.PauseAndSystemUpdate)
                return;
            if (Input_Status == Input_Status_Enum.Pause)
                Input_Status = Input_Status_Enum.Input;
            if (Examination_TextLine_3.Text.Length == Examination_TextLine_3.BindingLabel.TextString.Length)
                Examination_TextLine_4.Focus();
            if (Input_Status == Input_Status_Enum.Input)
                UpdateStats();
        }

        private void Examination_TextLine_4_TextChanged(object sender, EventArgs e)
        {
            if (Input_Status == Input_Status_Enum.SystemUpdate || Input_Status == Input_Status_Enum.PauseAndSystemUpdate)
                return;
            if (Input_Status == Input_Status_Enum.Pause)
                Input_Status = Input_Status_Enum.Input;
            if (Examination_TextLine_4.Text.Length == Examination_TextLine_4.BindingLabel.TextString.Length)
                Examination_TextLine_5.Focus();
            if (Input_Status == Input_Status_Enum.Input)
                UpdateStats();
        }

        private void Examination_TextLine_5_TextChanged(object sender, EventArgs e)
        {
            if (Input_Status == Input_Status_Enum.SystemUpdate || Input_Status == Input_Status_Enum.PauseAndSystemUpdate)
                return;
            if (Input_Status == Input_Status_Enum.Pause)
                Input_Status = Input_Status_Enum.Input;
            if (Input_Status == Input_Status_Enum.Input)
                UpdateStats();
            if (Examination_TextLine_5.Text.Length == Examination_TextLine_5.BindingLabel.TextString.Length)
                LoadNextExaminationPage();
        }

        private void Button_Pause_Continue_Click(object sender, EventArgs e)
        {
            if (Input_Status == Input_Status_Enum.Input)
            {
                Input_Status = Input_Status_Enum.Pause;
            }
            else if (Input_Status == Input_Status_Enum.Pause)
            {
                Input_Status = Input_Status_Enum.Input;
            }
        }

        private void Button_Start_Click(object sender, EventArgs e)
        {
            Thread JumpToExaminationThread = new Thread(new ThreadStart(delegate {
                Invoke((EventHandler)delegate
                {
                    ProcessBar_Start.Visible = true;
                    if (Input_Status == Input_Status_Enum.Stop)
                    {
                        Input_Status = Input_Status_Enum.Pause;
                    }
                });
                Thread.Sleep(1500);
                Invoke((EventHandler)delegate
                {
                    if (Input_Status == Input_Status_Enum.Pause)
                    {
                        Stats_Time = 0;
                        TabControl_Main.SelectedTab = TabPage_Examination;
                    }
                    ProcessBar_Start.Visible = false;
                });
            }));
            JumpToExaminationThread.Start();
        }

        private void Button_Previous_Page_Click(object sender, EventArgs e)
        {
            LoadPreviousExaminationPage();
        }

        private void Button_Next_Page_Click(object sender, EventArgs e)
        {
            LoadNextExaminationPage();
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            
        }

        private void Button_Complete_Click(object sender, EventArgs e)
        {
            if (Stats_Char_Current_Total != Stats_Char_Total)
                return;
            if(Timer_UpdateStats.Enabled)
                Timer_UpdateStats.Enabled = false;
            Enabled = false;
            Thread ThreadLoadResultPage = new Thread(new ThreadStart(LoadResultPage));
            ThreadLoadResultPage.Start();
        }

        /// <summary>
        /// 当前页数（每页五行）
        /// </summary>
        int CurrentPageIndex = 0;

        /// <summary>
        /// 行列表
        /// </summary>
        public List<ExaminationController.TextLine> TextLineList;

        /// <summary>
        /// 加载下一页
        /// </summary>
        private void LoadNextExaminationPage()
        {
            if ((float)CurrentPageIndex + 1.0 >= TextLineList.Count / 5.0)
                return;
            if(Input_Status == Input_Status_Enum.Pause)
                Input_Status = Input_Status_Enum.PauseAndSystemUpdate;
            else if(Input_Status == Input_Status_Enum.Input)
                Input_Status = Input_Status_Enum.SystemUpdate;
            RecordCurrentPageTextLine();
            CurrentPageIndex++;
            Examination_Lable_1.TextString = GetExaminationStringByIndex(CurrentPageIndex * 5 + 0);
            Examination_Lable_2.TextString = GetExaminationStringByIndex(CurrentPageIndex * 5 + 1);
            Examination_Lable_3.TextString = GetExaminationStringByIndex(CurrentPageIndex * 5 + 2);
            Examination_Lable_4.TextString = GetExaminationStringByIndex(CurrentPageIndex * 5 + 3);
            Examination_Lable_5.TextString = GetExaminationStringByIndex(CurrentPageIndex * 5 + 4);
            Examination_TextLine_1.Text = GetUserTextByIndex(CurrentPageIndex * 5 + 0);
            Examination_TextLine_2.Text = GetUserTextByIndex(CurrentPageIndex * 5 + 1);
            Examination_TextLine_3.Text = GetUserTextByIndex(CurrentPageIndex * 5 + 2);
            Examination_TextLine_4.Text = GetUserTextByIndex(CurrentPageIndex * 5 + 3);
            Examination_TextLine_5.Text = GetUserTextByIndex(CurrentPageIndex * 5 + 4);
            Examination_TextLine_1.Focus();
            if (Input_Status == Input_Status_Enum.PauseAndSystemUpdate)
                Input_Status = Input_Status_Enum.Pause;
            else if (Input_Status == Input_Status_Enum.SystemUpdate)
                Input_Status = Input_Status_Enum.Input;
        }

        /// <summary>
        /// 加载上一页
        /// </summary>
        private void LoadPreviousExaminationPage()
        {
            if (CurrentPageIndex == 0)
                return;
            if (Input_Status == Input_Status_Enum.Pause)
                Input_Status = Input_Status_Enum.PauseAndSystemUpdate;
            else if (Input_Status == Input_Status_Enum.Input)
                Input_Status = Input_Status_Enum.SystemUpdate;
            RecordCurrentPageTextLine();
            CurrentPageIndex--;
            Examination_Lable_1.TextString = GetExaminationStringByIndex(CurrentPageIndex * 5 + 0);
            Examination_Lable_2.TextString = GetExaminationStringByIndex(CurrentPageIndex * 5 + 1);
            Examination_Lable_3.TextString = GetExaminationStringByIndex(CurrentPageIndex * 5 + 2);
            Examination_Lable_4.TextString = GetExaminationStringByIndex(CurrentPageIndex * 5 + 3);
            Examination_Lable_5.TextString = GetExaminationStringByIndex(CurrentPageIndex * 5 + 4);
            Examination_TextLine_1.Text = GetUserTextByIndex(CurrentPageIndex * 5 + 0);
            Examination_TextLine_2.Text = GetUserTextByIndex(CurrentPageIndex * 5 + 1);
            Examination_TextLine_3.Text = GetUserTextByIndex(CurrentPageIndex * 5 + 2);
            Examination_TextLine_4.Text = GetUserTextByIndex(CurrentPageIndex * 5 + 3);
            Examination_TextLine_5.Text = GetUserTextByIndex(CurrentPageIndex * 5 + 4);
            Examination_TextLine_5.Focus();
            if (Input_Status == Input_Status_Enum.PauseAndSystemUpdate)
                Input_Status = Input_Status_Enum.Pause;
            else if (Input_Status == Input_Status_Enum.SystemUpdate)
                Input_Status = Input_Status_Enum.Input;
        }

        /// <summary>
        /// 记录当前页的 UserText
        /// </summary>
        private void RecordCurrentPageTextLine()
        {
            SetTextLineUserText(CurrentPageIndex * 5 + 0, Examination_Lable_1.TextFieldString);
            SetTextLineUserText(CurrentPageIndex * 5 + 1, Examination_Lable_2.TextFieldString);
            SetTextLineUserText(CurrentPageIndex * 5 + 2, Examination_Lable_3.TextFieldString);
            SetTextLineUserText(CurrentPageIndex * 5 + 3, Examination_Lable_4.TextFieldString);
            SetTextLineUserText(CurrentPageIndex * 5 + 4, Examination_Lable_5.TextFieldString);
        }

        /// <summary>
        /// 为 TextLine 设置 UserText
        /// </summary>
        /// <param name="index"></param>
        /// <param name="UserText"></param>
        private void SetTextLineUserText(int index, string UserText)
        {
            if (index >= TextLineList.Count)
                return;
            else
                TextLineList[index].UserText = UserText;
        }

        /// <summary>
        /// 根据索引号获取行字符串 ExaminationString
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private string GetExaminationStringByIndex(int index)
        {
            if (index >= TextLineList.Count)
                return string.Empty;
            else
                return TextLineList[index].ExaminationText;
        }

        /// <summary>
        /// 根据索引号获取行字符串 UserText 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private string GetUserTextByIndex(int index)
        {
            if (index >= TextLineList.Count)
                return string.Empty;
            else
                return TextLineList[index].UserText;
        }

        /// <summary>
        /// 加载考试
        /// </summary>
        private void LoadExamination(string str)
        {
            try
            {
                if (UserInformation.OnLine)
                {
                    UserInformation.GUID = new ServiceReference.ClientServiceSoapClient().GetExaminationGUID(
                        UserInformation.Number,
                        UserInformation.Department,
                        UserInformation.Major,
                        UserInformation.Class,
                        UserInformation.Name,
                        UserInformation.ContentMD5,
                        UserInformation.ContentTitle,
                        UserInformation.BatchID,
                        UserInformation.ExamRoomID
                        );
                    if (UserInformation.GUID == "md5 error")
                    {
                        MessageBox.Show(this, "试题MD5值校验错误\n\n服务器试题库中未查询到此试题\n\n成绩将不会被服务器记录", "错误");
                    }
                    else if (UserInformation.GUID == "database error")
                    {
                        MessageBox.Show(this, "服务器内部错误\n\n无法获取线上测试编号\n\n成绩将不会被服务器记录", "错误");
                    }
                    else
                        Timer_UpdateStats.Enabled = true;
                }
            }
            catch
            {

            }
            TabControl_Main.SelectedTab = TabPage_Start;
            ExaminationController.Reset(str);
            ExaminationController.Spilt(Examination_Lable_1.Font, Examination_Lable_1.Width);

            Stats_Time = 0;
            Stats_Char_Current_Total = 0;
            Stats_Char_Correct_Total = 0;
            Stats_Char_Total = 0;
            Input_Status = Input_Status_Enum.Stop;
            CurrentPageIndex = 0;

            TextLineList = ExaminationController.GetSpiltList();

            #region 获取字符总数
            {
                int CharTotal = 0;
                foreach (var l in TextLineList)
                    CharTotal += l.ExaminationText.Length;
                Stats_Char_Total = CharTotal;
            }
            #endregion

            Examination_Lable_1.TextString = GetExaminationStringByIndex(0);
            Examination_Lable_2.TextString = GetExaminationStringByIndex(1);
            Examination_Lable_3.TextString = GetExaminationStringByIndex(2);
            Examination_Lable_4.TextString = GetExaminationStringByIndex(3);
            Examination_Lable_5.TextString = GetExaminationStringByIndex(4);

        }

        #endregion

        #region Examination Result

        private void LoadExaminationResult()
        {

        }

        #endregion

        #region Stats

        int _Stats_Time = 0;
        /// <summary>
        /// 输入时间
        /// </summary>
        public int Stats_Time
        {
            get
            {
                return _Stats_Time;
            }

            set
            {
                _Stats_Time = value;
                if (Input_Status != Input_Status_Enum.Stop)
                    UpdateStats();
            }
        }

        int _Stats_Char_Current_Total = 0;
        /// <summary>
        /// 输入字符数
        /// </summary>
        public int Stats_Char_Current_Total
        {
            get
            {
                return _Stats_Char_Current_Total;
            }

            set
            {
                _Stats_Char_Current_Total = value;
                if (value == Stats_Char_Total)
                {
                    Input_Status = Input_Status_Enum.Pause;
                    Button_Complete.Visible = true;
                }
                else
                {
                    Button_Complete.Visible = false;
                }
            }
        }

        int _Stats_Char_Correct_Total = 0;
        /// <summary>
        /// 输入正确字符数
        /// </summary>
        public int Stats_Char_Correct_Total
        {
            get
            {
                return _Stats_Char_Correct_Total;
            }

            set
            {
                _Stats_Char_Correct_Total = value;
            }
        }

        int _Stats_Char_Total = 0;
        /// <summary>
        /// 当前文档字符总数
        /// </summary>
        public int Stats_Char_Total
        {
            get
            {
                return _Stats_Char_Total;
            }

            set
            {
                _Stats_Char_Total = value;
            }
        }

        enum Input_Status_Enum
        {
            /// <summary>
            /// 正在输入
            /// </summary>
            Input,
            /// <summary>
            /// 暂停
            /// </summary>
            Pause,
            /// <summary>
            /// 停止
            /// </summary>
            Stop,
            /// <summary>
            /// 状态更新
            /// </summary>
            SystemUpdate,
            /// <summary>
            /// 暂停且状态更新
            /// </summary>
            PauseAndSystemUpdate,
        }
        Input_Status_Enum _Input_Status = Input_Status_Enum.Stop;
        /// <summary>
        /// 输入状态
        /// </summary>
        private Input_Status_Enum Input_Status
        {
            get
            {
                return _Input_Status;
            }

            set
            {
                _Input_Status = value;
                if (value == Input_Status_Enum.Pause || value == Input_Status_Enum.SystemUpdate || value == Input_Status_Enum.PauseAndSystemUpdate)
                    Timer_Clocks.Enabled = false;
                else if (value == Input_Status_Enum.Input)
                    Timer_Clocks.Enabled = true;
                if (value == Input_Status_Enum.Pause)
                    Button_Pause_Continue.Text = "继续";
                if (value == Input_Status_Enum.Input)
                    Button_Pause_Continue.Text = "暂停";
            }
        }

        /// <summary>
        /// 计算输入字符数
        /// </summary>
        private void Count_Stats_Char_Current_Total()
        {
            int temp = 0;
            foreach (var l in TextLineList)
            {
                temp += l.UserText.Length;
            }
            Stats_Char_Current_Total = temp;
        }

        /// <summary>
        /// 计算输入正确字符数
        /// </summary>
        private void Count_Stats_Char_Correct_Total()
        {
            int temp = 0;
            foreach (var l in TextLineList)
            {
                for (int i = 0; i < l.UserText.Length; ++i)
                {
                    if (i >= l.ExaminationText.Length)
                        break;
                    if (l.UserText[i] == l.ExaminationText[i])
                        temp++;
                }
            }
            Stats_Char_Correct_Total = temp;
        }

        private void Timer_Clocks_Tick(object sender, EventArgs e)
        {
            Stats_Time++;
        }

        /// <summary>
        /// 更新统计数据
        /// </summary>
        private void UpdateStats()
        {
            RecordCurrentPageTextLine();
            Count_Stats_Char_Current_Total();
            Count_Stats_Char_Correct_Total();
            Label_Stats_Time.Text = string.Format(Label_Stats_Time.Tag.ToString(), Stats_Time / 60, Stats_Time % 60,
                (Stats_Char_Current_Total == 0 ? 100 : (int)((float)Stats_Char_Correct_Total / Stats_Char_Current_Total * 100)) + "%",
                (Stats_Time == 0 ? 0 : (int)((float)Stats_Char_Current_Total / Stats_Time * 60.0)),
                (Stats_Char_Total == 0 ? 0 : (int)((float)Stats_Char_Current_Total / Stats_Char_Total * 100)) + "%");
        }

        #endregion

        #region Select Examination

        Thread SearchExaminationThread = null;

        string SearchKeyword = "";

        private void Text_SearchExamination_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SearchKeyword = Text_SearchExamination.Text;
                ProcessBar_SearchExamination.Visible = false;
                ProcessBar_SearchExamination.Top = 37;
                if (SearchExaminationThread != null)
                    SearchExaminationThread.Abort();
                Timer_SearchExamination.Enabled = false;
                Timer_SearchExamination.Enabled = true;
            }
            catch
            {

            }
        }

        private void Timer_SearchExamination_Tick(object sender, EventArgs e)
        {
            try
            {
                if (SearchExaminationThread == null)
                    SearchExaminationThread = new Thread(new ThreadStart(SearchExamination));
                else
                {
                    SearchExaminationThread.Abort();
                    SearchExaminationThread = new Thread(new ThreadStart(SearchExamination));
                }
                SearchExaminationThread.IsBackground = true;
                SearchExaminationThread.Start();
            }
            catch
            {

            }
            finally
            {
                Timer_SearchExamination.Enabled = false;
            }
        }

        private void SearchExamination()
        {
            try
            {
                Invoke((EventHandler)delegate
                {
                    ProcessBar_SearchExamination.Visible = true;
                });
                bool needbreak = false;
                while (!needbreak)
                {
                    Thread.Sleep(50);
                    Invoke((EventHandler)delegate
                    {
                        ProcessBar_SearchExamination.Top++;
                        if (ProcessBar_SearchExamination.Top >= 41)
                            needbreak = true;
                    });
                }
                var dt = db.GetContentByKeyword(SearchKeyword, UserInformation.OnLineExamination && UserInformation.OnLine);
                Invoke((EventHandler)delegate
                {
                    ListView_ExaminationList.Items.Clear();
                });
                int dealy = 500 / (dt.Rows.Count + 1);
                foreach (DataRow row in dt.Rows)
                {
                    Thread.Sleep(dealy);
                    Invoke((EventHandler)delegate
                    {
                        ListViewItem lvi = new ListViewItem(row[0].ToString());
                        lvi.SubItems.Add(row[2].ToString());
                        lvi.SubItems.Add(row[1].ToString().Length > 50 ? row[1].ToString().Substring(0, 50) : row[1].ToString());
                        lvi.SubItems.Add(row[3].ToString());
                        ListView_ExaminationList.Items.Add(lvi);
                    });
                }
                Thread.Sleep(1000);
            }
            catch
            {

            }
            finally
            {
                Invoke((EventHandler)delegate
                {
                    ProcessBar_SearchExamination.Visible = false;
                    ProcessBar_SearchExamination.Top = 37;
                });
            }
        }

        private void Button_SelectText_Return_Click(object sender, EventArgs e)
        {
            if (UserInformation.OnLine)
                TabControl_Main.SelectedTab = TabPage_Main;
            else
                TabControl_Main.SelectedTab = TabPage_Select;
        }

        private void Button_SelectText_Import_Click(object sender, EventArgs e)
        {
            Thread ImportTextFileThread = new Thread(new ThreadStart(ImportTextFile));
            ImportTextFileThread.Start();
        }

        private void ImportTextFile()
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                string fileName = string.Empty;
                string title = string.Empty;
                Invoke((EventHandler)delegate
                {
                    Enabled = false;
                    openFile.Title = "请选择文本文件";
                    openFile.Filter = "文本文件(*.txt)|*.txt";
                    openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    openFile.Multiselect = false;
                    if (openFile.ShowDialog() == DialogResult.Cancel)
                        return;
                    fileName = openFile.FileName;
                    title = openFile.SafeFileName;
                });
                if (string.IsNullOrEmpty(fileName))
                    return;
                var fileContent = ReadFile(fileName);
                if (db.InsertNewContent(title, fileContent))
                    Invoke((EventHandler)delegate
                    {
                        MessageBox.Show(this, "导入成功\n\n" + fileName + "\n\n共计 " + fileContent.Length + " 字符", "提示");
                    });
                else
                    Invoke((EventHandler)delegate
                    {
                        MessageBox.Show(this, "导入失败\n\n" + fileName + "\n\n已包含相同内容文本", "提示");
                    });
            }
            catch (Exception e)
            {
                Invoke((EventHandler)delegate
                {
                    MessageBox.Show(this, "导入失败\n\n" + e.Message, "提示");
                });
            }
            finally
            {
                Invoke((EventHandler)delegate
                {
                    RefreshExaminationList();
                    Enabled = true;
                });
            }
        }

        public string ReadFile(string path)
        {
            StreamReader sr = new StreamReader(path, Encoding.Default);
            string line = string.Empty;
            string res = string.Empty;
            while ((line = sr.ReadLine()) != null)
                res += line;
            sr.Dispose();
            return res;
        }

        private void LoadExaminationList()
        {
            try
            {
                Invoke((EventHandler)delegate
                {
                    ProcessBar_Login.Visible = true;
                });
                Update_Label_Login_Tip(Color.Black, "正在尝试获取试题库");
                Thread.Sleep(500);
                var ds = new ServiceReference.ClientServiceSoapClient().GetAllContent();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    string title = dr["Title"].ToString();
                    string content = dr["String"].ToString();
                    db.InsertNewContent(title, content);
                }
            }
            catch
            {
                Update_Label_Login_Tip(Color.Red, "连接服务器失败");
                Thread.Sleep(500);
            }
            finally
            {
                Update_Label_Login_Tip(Color.Black, "正在加载界面");
                Thread.Sleep(500);
                RefreshExaminationList();
                Invoke((EventHandler)delegate
                {
                    ProcessBar_Login.Visible = false;
                    TabControl_Main.SelectedTab = TabPage_SelectText;
                    Update_Label_Login_Tip(Color.Black);
                });
            }
        }

        private void RefreshExaminationList()
        {
            var dt = db.GetAllContent(UserInformation.OnLineExamination && UserInformation.OnLine);
            Invoke((EventHandler)delegate
            {
                ListView_ExaminationList.Items.Clear();
                ListView_ExaminationList.BeginUpdate();
                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem lvi = new ListViewItem(row[0].ToString());
                    lvi.SubItems.Add(row[2].ToString());
                    lvi.SubItems.Add(row[1].ToString().Length > 50 ? row[1].ToString().Substring(0, 50) : row[1].ToString());
                    lvi.SubItems.Add(row[3].ToString());
                    ListView_ExaminationList.Items.Add(lvi);
                }
                ListView_ExaminationList.EndUpdate();
            });
        }

        private void ListView_ExaminationList_Resize(object sender, EventArgs e)
        {
            ColumnHeader_ExaminationList_MD5.Width = 0;
            ColumnHeader_ExaminationList_Preview.Width =
                ListView_ExaminationList.Width -
                ColumnHeader_ExaminationList_Title.Width -
                ColumnHeader_ExaminationList_Length.Width;
        }

        private void Button_SelectText_Begin_Click(object sender, EventArgs e)
        {
            if (ListView_ExaminationList.SelectedItems.Count == 0)
            {
                MessageBox.Show(this, "请选中一项后再操作", "提示");
                return;
            }
            string md5 = ListView_ExaminationList.SelectedItems[0].SubItems[3].Text;
            string content = db.GetContentByMD5(md5);
            if (string.IsNullOrEmpty(content))
                return;
            UserInformation.ContentMD5 = md5;
            UserInformation.ContentTitle = ListView_ExaminationList.SelectedItems[0].SubItems[0].Text;
            LoadExamination(content);
        }

        private void ListView_ExaminationList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Button_SelectText_Begin.PerformClick();
        }

        #endregion

        #region Login

        private void Button_OnLineReturn_Click(object sender, EventArgs e)
        {
            TabControl_Main.SelectedTab = TabPage_Select;
        }

        /// <summary>
        /// 在线测试登陆状态
        /// </summary>
        enum OnLineSelectStatsEnum
        {
            /// <summary>
            /// 默认状态
            /// </summary>
            Default,
            /// <summary>
            /// 登陆教务
            /// </summary>
            Login,
            /// <summary>
            /// 选择测试内容
            /// </summary>
            SelectContent,
            /// <summary>
            /// 完成
            /// </summary>
            Finish
        }

        OnLineSelectStatsEnum onLineSelectStats = OnLineSelectStatsEnum.Default;

        private OnLineSelectStatsEnum OnLineSelectStats
        {
            get
            {
                return onLineSelectStats;
            }

            set
            {
                onLineSelectStats = value;
            }
        }

        private void FlatButton_Select_Login_Click(object sender, EventArgs e)
        {
            if (ProcessBar_Login.Visible == true)
                return;
            UserInformation.BatchID = "";
            UserInformation.BatchTitle = "";
            UserInformation.Class = "";
            UserInformation.ContentID = "";
            UserInformation.ContentMD5 = "";
            UserInformation.ContentTitle = "";
            UserInformation.Department = "";
            UserInformation.ExamRoomID = "";
            UserInformation.ExamRoomTitle = "";
            UserInformation.GUID = "";
            UserInformation.Major = "";
            UserInformation.Name = "";
            UserInformation.OnLine = false;
            UserInformation.OnLineExamination = false;
            UserInformation.Number = TextField_UserName.Text;
            UserInformation.Password = TextField_PassWord.Text;
            if (string.IsNullOrEmpty(UserInformation.Number))
            {
                Update_Label_Login_Tip(Color.Red, "请输入用户名");
                return;
            }
            if (string.IsNullOrEmpty(UserInformation.Password))
            {
                Update_Label_Login_Tip(Color.Red, "请输入密码");
                return;
            }
            Thread ThreadLogin = new Thread(new ThreadStart(Login));
            ThreadLogin.Start();
        }

        /// <summary>
        /// 更新 Label_Login_Tip.Text
        /// </summary>
        /// <param name="str"></param>
        private void Update_Label_Login_Tip(Color ForeColor, string str = "使用教务系统账号登录")
        {
           Invoke((EventHandler)delegate
           {
               Label_Login_Tip.ForeColor = ForeColor;
               Label_Login_Tip.Text = str;
           });
        }

        private void Login()
        {
            try
            {
                Invoke((EventHandler)delegate
                {
                    ProcessBar_Login.Visible = true;
                });
                Update_Label_Login_Tip(Color.Black, "连接服务器");
                Thread.Sleep(250);
                string str = new ServiceReference.ClientServiceSoapClient().SayHello("Hello Server");
                if (str != "Hello Client")
                {
                    if(str == "Error")
                        Update_Label_Login_Tip(Color.Red, "连接服务器失败");
                    else
                        Update_Label_Login_Tip(Color.Red, str);
                    return;
                }
                Thread.Sleep(250);
                Update_Label_Login_Tip(Color.Black, "验证账户信息");
                var res = new ServiceReference.ClientServiceSoapClient().GetUserInfo(UserInformation.Number, UserInformation.Password);
                if (res == "password error")
                {
                    Update_Label_Login_Tip(Color.Red, "密码错误");
                    return;
                }
                else if (res == "username error")
                {
                    Update_Label_Login_Tip(Color.Red, "用户名错误");
                    return;
                }
                else if (res == "checkcode error")
                {
                    Update_Label_Login_Tip(Color.Red, "未知错误");
                    return;
                }
                else if (res.Split(',').Length != 5)
                {
                    Update_Label_Login_Tip(Color.Red, "未知错误");
                    Invoke((EventHandler)delegate
                    {
                        MessageBox.Show(this, res, "错误");
                    });
                    return;
                }
                else
                {
                    Update_Label_Login_Tip(Color.Black, "获取账户信息");
                    Thread.Sleep(300);
                    var res_array = res.Split(',');
                    UserInformation.Department = res_array[0];
                    UserInformation.Major = res_array[1];
                    UserInformation.Class = res_array[2];
                    UserInformation.Name = res_array[3];
                    UserInformation.Number = res_array[4];
                    UserInformation.OnLine = true;
                    Update_Label_Login_Tip(Color.Black, "登录成功");
                    Thread.Sleep(250);
                    Update_Label_Login_Tip(Color.Black, "获取考场信息");
                    Thread.Sleep(250);
                    {
                        var temp = new ServiceReference.ClientServiceSoapClient().GetBatchID();
                        int tempid = 1;                        
                        if (!string.IsNullOrEmpty(temp) && int.TryParse(temp, out tempid))
                        {
                            UserInformation.BatchID = temp;
                            UserInformation.BatchTitle = new ServiceReference.ClientServiceSoapClient().GetBatchTitle();
                        }
                        temp = new ServiceReference.ClientServiceSoapClient().GetExamRoomID();
                        if (!string.IsNullOrEmpty(temp) && int.TryParse(temp, out tempid))
                        {
                            UserInformation.ExamRoomID = temp;
                            UserInformation.ExamRoomTitle = new ServiceReference.ClientServiceSoapClient().GetExamRoomTitle();
                        }
                    }
                    Update_Label_Login_Tip(Color.Black, "正在获取试题库");
                    try
                    {
                        var ds = new ServiceReference.ClientServiceSoapClient().GetAllContent();
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            string title = dr["Title"].ToString();
                            string content = dr["String"].ToString();
                            db.InsertNewContent(title, content);
                        }
                        db.ClearOnlineContent();
                        ds = new ServiceReference.ClientServiceSoapClient().GetAllContentOnlineBatch();
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            string title = dr["Title"].ToString();
                            string content = dr["String"].ToString();
                            db.InsertNewOnlineContent(title, content);
                        }
                    }
                    catch { }
                    Thread.Sleep(250);
                    Update_Label_Login_Tip(Color.Black, "正在加载界面");
                    RefreshExaminationList();
                    Thread.Sleep(250);
                    Invoke((EventHandler)delegate
                    {
                        if (string.IsNullOrEmpty(UserInformation.BatchID))
                            Button_Main_OnlineExam.Enabled = false;
                        else
                            Button_Main_OnlineExam.Enabled = true;
                        Text_Main_Class.Text = UserInformation.Class.IndexOf("班") > 0 ? UserInformation.Class : UserInformation.Class + "班";
                        Text_Main_Department.Text = UserInformation.Department.IndexOf("系") > 0 ? UserInformation.Department : UserInformation.Department + "系";
                        Text_Main_ExamRoom.Text = UserInformation.ExamRoomTitle;
                        Text_Main_Major.Text = UserInformation.Major.IndexOf("专业") > 0 ? UserInformation.Major : UserInformation.Major + "专业";
                        Text_Main_Batch.Text = string.IsNullOrEmpty(UserInformation.BatchTitle) ? "当前暂无正在进行的考试" : UserInformation.BatchTitle;
                        Text_Main_Number.Text = UserInformation.Number;
                        Text_Main_Name.Text = UserInformation.Name;
                        TabControl_Main.SelectedTab = TabPage_Main;
                    });
                    Update_Label_Login_Tip(Color.Black);
                }
            }
            catch (System.ServiceModel.CommunicationException)
            {
                Update_Label_Login_Tip(Color.Red, "连接服务器失败");
            }
            catch (TimeoutException)
            {
                Update_Label_Login_Tip(Color.Red, "连接服务器超时");
            }
            finally
            {
                Invoke((EventHandler)delegate
                {
                    ProcessBar_Login.Visible = false;
                });
            }
        }

        private void TextField_PassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                FlatButton_Select_Login.PerformClick();
        }

        private void TextField_UserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                TextField_PassWord.Focus();
        }

        #endregion

        #region Update Stats

        private void Timer_UpdateStats_Tick(object sender, EventArgs e)
        {
            string str_Input_Status = string.Empty;
            switch (Input_Status)
            {
                case Input_Status_Enum.Input:
                    str_Input_Status = "输入中";
                    break;
                case Input_Status_Enum.Pause:
                    str_Input_Status = "暂停";
                    break;
                case Input_Status_Enum.PauseAndSystemUpdate:
                    str_Input_Status = "暂停";
                    break;
                case Input_Status_Enum.Stop:
                    str_Input_Status = "停止";
                    break;
                case Input_Status_Enum.SystemUpdate:
                    str_Input_Status = "输入中";
                    break;
            }
            double CorrectPercent = Stats_Char_Current_Total == 0 ? 1.00 : ((double)Stats_Char_Correct_Total / Stats_Char_Total * 1.00);
            double Process = Stats_Char_Current_Total == 0 ? 0 : ((double)Stats_Char_Current_Total / Stats_Char_Total);
            int Speed = Stats_Time == 0 ? 0 : (int)((double)Stats_Char_Current_Total / Stats_Time * 60.0);
            int Time = Stats_Time;
            new ServiceReference.ClientServiceSoapClient().UpdateExaminationStats(
                UserInformation.GUID,
                str_Input_Status,
                Speed.ToString(),
                Process.ToString(),
                CorrectPercent.ToString());
        }

        #endregion

        #region Result Page

        private void LoadResultPage()
        {
            double CorrectPercent = Stats_Char_Current_Total == 0 ? 1.00 : ((double)Stats_Char_Correct_Total / Stats_Char_Total * 1.00);
            double Process = Stats_Char_Current_Total == 0 ? 0 : ((double)Stats_Char_Current_Total / Stats_Char_Total);
            int Speed = Stats_Time == 0 ? 0 : (int)((double)Stats_Char_Current_Total / Stats_Time * 60.0);
            int Time = Stats_Time;
            int Total = Stats_Char_Total;
            double FinalScore = Speed * CorrectPercent;
            try
            {
                Invoke((EventHandler)delegate
                {
                    Text_Result_CorrectPercent.Text = (CorrectPercent * 100).ToString("N2") + " % ";
                    Text_Result_FinalScore.Text = FinalScore.ToString("N2") + " 分 ";
                    Text_Result_Speed.Text = Speed.ToString("N2") + " 字/分 ";
                    Text_Result_Time.Text = Time / 60 + " 分 " + Time % 60 + " 秒 ";
                    Text_Result_Total.Text = Total.ToString() + " 字 ";
                    Label_Result_Tip_Percent.Visible = false;
                    Progress_Result_Percent.Visible = false;
                    if (UserInformation.OnLine)
                    {
                        Label_Result_Tip_SendResult.Text = "正在将成绩提交至服务器";
                        Panel_Result_Online.Visible = true;
                        Process_Result_SendResult.Visible = true;
                    }
                    else
                        Panel_Result_Online.Visible = false;
                    TabControl_Main.SelectedTab = TabPage_Result;
                    Enabled = true;
                });
                if (UserInformation.OnLine)
                {
                    Thread.Sleep(5000);
                    string res = "提交成绩失败";
                    Invoke((EventHandler)delegate
                    {
                        try
                        {
                            res = new ServiceReference.ClientServiceSoapClient().UpdateFinallyScore(
                            UserInformation.GUID, Speed.ToString(), Process.ToString(), CorrectPercent.ToString());
                        }
                        catch
                        {

                        }
                        if (res == "ok")
                        {
                            Label_Result_Tip_SendResult.Text = "成绩已成功提交至服务器";
                            Label_Result_Tip_Percent.Text = "正在获取线上排名";
                            Label_Result_Tip_Percent.Visible = true;
                        }
                        else
                        {
                            Process_Result_SendResult.Visible = false;
                            Label_Result_Tip_SendResult.Text = res;
                        }
                    });
                    if (res != "ok")
                        return;
                    Thread.Sleep(3000);
                    var rank = new ServiceReference.ClientServiceSoapClient().GetOnlineRank(UserInformation.GUID);
                    Invoke((EventHandler)delegate
                    {
                        Process_Result_SendResult.Visible = false;
                        double d_rank = 0;
                        if (rank.IndexOf("error") > 0 || !double.TryParse(rank, out d_rank))
                        {
                            Label_Result_Tip_Percent.Text = "线上排名获取失败";
                        }
                        else
                        {
                            Label_Result_Tip_Percent.Text = string.Format("您的成绩已超过{0:N2}%的人", d_rank * 100);
                            Progress_Result_Percent.PercentValue = d_rank;
                            Progress_Result_Percent.Visible = true;
                        }
                    });
                };
            }
            catch
            {

            }
            finally
            {
                Invoke((EventHandler)delegate
                {
                    TabControl_Main.SelectedTab = TabPage_Result;
                    Enabled = true;
                });
            }
        }

        private void Button_Result_Close_Click(object sender, EventArgs e)
        {
            if (Process_Result_SendResult.Visible)
                return;
            TabControl_Main.SelectedTab = TabPage_SelectText;
        }

        #endregion

        #region Main

        private void Button_Main_Free_Click(object sender, EventArgs e)
        {
            UserInformation.OnLineExamination = false;
            Thread ThreadRefreshExaminationList = new Thread(new ThreadStart(delegate 
            {
                Invoke((EventHandler)delegate
                {
                    Enabled = false;
                });
                RefreshExaminationList();
                Invoke((EventHandler)delegate
                {
                    Button_SelectText_Import.Visible = false;
                    TabControl_Main.SelectedTab = TabPage_SelectText;
                    Enabled = true;
                });
            }));
            ThreadRefreshExaminationList.Start();
        }

        private void Button_Main_OnlineExam_Click(object sender, EventArgs e)
        {
            UserInformation.OnLineExamination = true;
            Thread ThreadRefreshExaminationList = new Thread(new ThreadStart(delegate
            {
                Invoke((EventHandler)delegate
                {
                    Enabled = false;
                });
                RefreshExaminationList();
                Invoke((EventHandler)delegate
                {
                    Button_SelectText_Import.Visible = false;
                    TabControl_Main.SelectedTab = TabPage_SelectText;
                    Enabled = true;
                });
            }));
            ThreadRefreshExaminationList.Start();
        }

        #endregion

        private void TabPage_Start_Click(object sender, EventArgs e)
        {

        }
    }
}

