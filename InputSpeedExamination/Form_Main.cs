﻿using System;
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

namespace InputSpeedExamination
{
    public partial class Form_Main : MaterialForm
    {

        #region Load

        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            NeedCenterControlList.Add(new NeedCenterControl(FlatButton_Select_OffLine, NeedCenterControlStyle.Horizontal));
            NeedCenterControlList.Add(new NeedCenterControl(FlatButton_Select_OnLine, NeedCenterControlStyle.Horizontal));
            NeedCenterControlList.Add(new NeedCenterControl(Panel_Start, NeedCenterControlStyle.Both));
            WebView_Select_BG.Navigate(Environment.CurrentDirectory + @"\sources\web\main\index.html");
            Form_Main_Resize(sender, e);
            debug();
        }

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
            debug();
            TabControl_Main.SelectedTab = TabPage_Start;
        }

        #endregion

        #region Examination

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
            PauseAndSystemUpdate
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
            Console.WriteLine("Count_Stats_Char_Current_Total Start at:" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "." + DateTime.Now.Millisecond);
            int temp = 0;
            foreach (var l in TextLineList)
            {
                temp += l.UserText.Length;
            }
            Stats_Char_Current_Total = temp;
            Console.WriteLine("Count_Stats_Char_Current_Total Finish at:" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "." + DateTime.Now.Millisecond);
        }

        /// <summary>
        /// 计算输入正确字符数
        /// </summary>
        private void Count_Stats_Char_Correct_Total()
        {
            Console.WriteLine("Count_Stats_Char_Correct_Total Start at:" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "." + DateTime.Now.Millisecond);
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
            Console.WriteLine("Count_Stats_Char_Correct_Total Finish at:" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "." + DateTime.Now.Millisecond);
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

    }
}

