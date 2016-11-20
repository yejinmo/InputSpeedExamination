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
            TabControl_Main.SelectedTab = TabPage_Examination;
            debug();
        }

        #endregion

        #region Examination

        private void Examination_TextLine_1_TextChanged(object sender, EventArgs e)
        {
            if (Input_Status == Input_Status_Enum.Pause)
                Input_Status = Input_Status_Enum.Input;
            if (Examination_TextLine_1.Text.Length == Examination_TextLine_1.BindingLabel.TextString.Length)
                Examination_TextLine_2.Focus();
        }

        private void Examination_TextLine_2_TextChanged(object sender, EventArgs e)
        {
            if (Input_Status == Input_Status_Enum.Pause)
                Input_Status = Input_Status_Enum.Input;
            if (Examination_TextLine_2.Text.Length == Examination_TextLine_2.BindingLabel.TextString.Length)
                Examination_TextLine_3.Focus();
        }

        private void Examination_TextLine_3_TextChanged(object sender, EventArgs e)
        {
            if (Input_Status == Input_Status_Enum.Pause)
                Input_Status = Input_Status_Enum.Input;
            if (Examination_TextLine_3.Text.Length == Examination_TextLine_3.BindingLabel.TextString.Length)
                Examination_TextLine_4.Focus();
        }

        private void Examination_TextLine_4_TextChanged(object sender, EventArgs e)
        {
            if (Input_Status == Input_Status_Enum.Pause)
                Input_Status = Input_Status_Enum.Input;
            if (Examination_TextLine_4.Text.Length == Examination_TextLine_4.BindingLabel.TextString.Length)
                Examination_TextLine_5.Focus();
        }

        private void Examination_TextLine_5_TextChanged(object sender, EventArgs e)
        {
            if (Input_Status == Input_Status_Enum.Pause)
                Input_Status = Input_Status_Enum.Input;
            if (Examination_TextLine_5.Text.Length == Examination_TextLine_5.BindingLabel.TextString.Length)
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
            RecordCurrentPageTextLineAndUpdateStats();
            CurrentPageIndex++;
            Examination_Lable_1.TextString = GetExaminationStringByIndex(CurrentPageIndex * 5 + 0);
            Examination_Lable_2.TextString = GetExaminationStringByIndex(CurrentPageIndex * 5 + 1);
            Examination_Lable_3.TextString = GetExaminationStringByIndex(CurrentPageIndex * 5 + 2);
            Examination_Lable_4.TextString = GetExaminationStringByIndex(CurrentPageIndex * 5 + 3);
            Examination_Lable_5.TextString = GetExaminationStringByIndex(CurrentPageIndex * 5 + 4);
            Examination_TextLine_1.Focus();
        }

        /// <summary>
        /// 加载上一页
        /// </summary>
        private void LoadPreviousExaminationPage()
        {
            if (CurrentPageIndex == 0)
                return;
            RecordCurrentPageTextLineAndUpdateStats();
            CurrentPageIndex--;
            Examination_Lable_1.TextString = GetExaminationStringByIndex(CurrentPageIndex * 5 + 0);
            Examination_Lable_2.TextString = GetExaminationStringByIndex(CurrentPageIndex * 5 + 1);
            Examination_Lable_3.TextString = GetExaminationStringByIndex(CurrentPageIndex * 5 + 2);
            Examination_Lable_4.TextString = GetExaminationStringByIndex(CurrentPageIndex * 5 + 3);
            Examination_Lable_5.TextString = GetExaminationStringByIndex(CurrentPageIndex * 5 + 4);
            Examination_TextLine_5.Focus();
        }

        /// <summary>
        /// 记录当前页的 UserText 并更新统计信息
        /// </summary>
        private void RecordCurrentPageTextLineAndUpdateStats()
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
        /// 根据索引号获取行字符串
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
        /// 加载考试
        /// </summary>
        private void LoadExamination()
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
            Stop
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
                if (value == Input_Status_Enum.Pause)
                    Timer_Clocks.Enabled = false;
                else if (value == Input_Status_Enum.Input)
                    Timer_Clocks.Enabled = true;
            }
        }

        private void Timer_Clocks_Tick(object sender, EventArgs e)
        {
            Stats_Time++;
        }

        #endregion        
        
        #region Debug

        string debug_str = @"
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
            ExaminationController.Reset(debug_str);
            ExaminationController.Spilt(Examination_Lable_1.Font, Examination_Lable_1.Width);

            TextLineList = ExaminationController.GetSpiltList();
            Examination_Lable_1.TextString = GetExaminationStringByIndex(0);
            Examination_Lable_2.TextString = GetExaminationStringByIndex(1);
            Examination_Lable_3.TextString = GetExaminationStringByIndex(2);
            Examination_Lable_4.TextString = GetExaminationStringByIndex(3);
            Examination_Lable_5.TextString = GetExaminationStringByIndex(4);
        }

        #endregion

    }
}
