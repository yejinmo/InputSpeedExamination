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
            /// 当前GUID
            /// </summary>
            public static string GUID = string.Empty;

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
            NeedCenterControlList.Add(new NeedCenterControl(Panel_Login, NeedCenterControlStyle.Both));
            NeedCenterControlList.Add(new NeedCenterControl(Panel_Start, NeedCenterControlStyle.Both));
            WebView_Select_BG.Navigate(Environment.CurrentDirectory + @"\sources\web\main\index.html");
            UserInformation.OnLineStatsChange = OnLineStatsChange;
            UserInformation.OnLine = false;
            Form_Main_Resize(sender, e);
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

        private void FlatButton_Select_OffLine_MouseMove(object sender, MouseEventArgs e)
        {
            //WebView_Select_BG.mouse
        }

        private void FlatButton_Select_OffLine_Click(object sender, EventArgs e)
        {
            Thread ThreadLoadExaminationList = new Thread(new ThreadStart(LoadExaminationList));
            ThreadLoadExaminationList.Start();
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
                    Input_Status = Input_Status_Enum.Pause;
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

        #region SelectExamination

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
                var dt = db.GetContentByKeyword(SearchKeyword);
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
                Thread.Sleep(200);
                RefreshExaminationList();
                Invoke((EventHandler)delegate
                {
                    TabControl_Main.SelectedTab = TabPage_SelectText;
                });
            }
            catch
            {

            }
        }

        private void RefreshExaminationList(DataTable dt = null)
        {
            if (dt == null)
                dt = db.GetAllContent();
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
            LoadExamination(content);
            TabControl_Main.SelectedTab = TabPage_Start;
        }

        private void ListView_ExaminationList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Button_SelectText_Begin.PerformClick();
        }

        #endregion

        #region Debug

        string debug_str = @"
示例文字
扮演年轻的聪明黑客马可仕．哈洛威（Marcus Holloway），来到技术革命的起源地：旧金山湾区。
加入最恶名昭彰的黑客团体 DedSec，执行史上最大规模的黑客行动，彻底消灭犯罪首脑用来大规模监视操控市民的侵入性运作系统 ctOS 2.0。 

探索动态开放世界，充满各种游戏操作可能。 
骇进每一组联机装置，控制城市公共设施。 
根据你的游戏风格培养不同技能，升级你的黑客工具：遥控车、四旋翼无人机、3D 打印武器和更多内容。 
在全新的合作模式和对抗式多人游戏与好友无缝联机，享受全新的《看门狗》游戏体验。
123456789
987654321
123456
654321
abcdef
123
321
456
654
abc
cba
";

        private void debug()
        {
            LoadExamination(debug_str);
            //ExaminationController.Reset(debug_str);
            //ExaminationController.Spilt(Examination_Lable_1.Font, Examination_Lable_1.Width);

            //TextLineList = ExaminationController.GetSpiltList();
            //Examination_Lable_1.TextString = GetExaminationStringByIndex(0);
            //Examination_Lable_2.TextString = GetExaminationStringByIndex(1);
            //Examination_Lable_3.TextString = GetExaminationStringByIndex(2);
            //Examination_Lable_4.TextString = GetExaminationStringByIndex(3);
            //Examination_Lable_5.TextString = GetExaminationStringByIndex(4);
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
                    UserInformation.GUID = string.Empty;
                    UserInformation.OnLine = true;
                    Update_Label_Login_Tip(Color.Black, "登录成功");
                    Thread.Sleep(250);
                    Update_Label_Login_Tip(Color.Black, "正在获取试题库");
                    var ds = new ServiceReference.ClientServiceSoapClient().GetAllContent();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        string title = dr["Title"].ToString();
                        string content = dr["String"].ToString();
                        db.InsertNewContent(title, content);
                    }
                    Thread.Sleep(250);
                    Update_Label_Login_Tip(Color.Black, "正在加载界面");
                    Invoke((EventHandler)delegate
                    {
                        FlatButton_Select_OffLine.PerformClick();
                    });
                    Thread.Sleep(250);
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

        #region UpdateStats

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
            new ServiceReference.ClientServiceSoapClient().UpdateExaminationStats(
                UserInformation.GUID,
                str_Input_Status,
                (Stats_Time == 0 ? 0 : (int)((float)Stats_Char_Current_Total / Stats_Time * 60.0)).ToString(),
                ((Stats_Char_Total == 0 ? 0 : (int)((float)Stats_Char_Current_Total / Stats_Char_Total * 100)) + "%"),
                (Stats_Char_Current_Total == 0 ? 100 : (int)((float)Stats_Char_Correct_Total / Stats_Char_Current_Total * 100)) + "%");
        }

        #endregion

    }
}

