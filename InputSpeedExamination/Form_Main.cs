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
            if (Examination_TextLine_1.Text.Length == Examination_TextLine_1.BindingLabel.TextString.Length)
                Examination_TextLine_2.Focus();
        }

        private void Examination_TextLine_2_TextChanged(object sender, EventArgs e)
        {
            if (Examination_TextLine_2.Text.Length == Examination_TextLine_2.BindingLabel.TextString.Length)
                Examination_TextLine_3.Focus();
        }

        private void Examination_TextLine_3_TextChanged(object sender, EventArgs e)
        {
            if (Examination_TextLine_3.Text.Length == Examination_TextLine_3.BindingLabel.TextString.Length)
                Examination_TextLine_4.Focus();
        }

        private void Examination_TextLine_4_TextChanged(object sender, EventArgs e)
        {
            if (Examination_TextLine_4.Text.Length == Examination_TextLine_4.BindingLabel.TextString.Length)
                Examination_TextLine_5.Focus();
        }

        private void Examination_TextLine_5_TextChanged(object sender, EventArgs e)
        {
            if (Examination_TextLine_5.Text.Length == Examination_TextLine_5.BindingLabel.TextString.Length)
                Examination_TextLine_1.Focus();
        }

        #endregion

        #region Debug

        string debug_str = @"visual foxpro常用命令
ADD  TABLE  在当前数据库中添加一个自由表                            
APPEND  在表的末尾添加一个或多个新记录                          
APPEND FROM ARRAY 由数组添加记录到表中                                    
APPEND FROM  从一个文件中读入记录，追加到当前表的尾部                
APPEND GENERAL 从文件中导入OLE对象并将其放入通用字段中                 
APPEND MEMO  将文本文件的内容复制到备注字段中                        
APPEND PROCEDURES 将文本文件中的存储过程追加到当前数据库中                
AVERAGE  计算数值表达式或字段的算术平均值                        
BLANK   清除当前记录中所有字段的数据                    ";

        private void debug()
        {
            ExaminationController.Reset(debug_str);
            ExaminationController.Spilt(Examination_Lable_1.Font, Examination_Lable_1.Width);

            Examination_Lable_1.TextString = ExaminationController.GetStringByIndex(0);
            Examination_Lable_2.TextString = ExaminationController.GetStringByIndex(1);
            Examination_Lable_3.TextString = ExaminationController.GetStringByIndex(2);
            Examination_Lable_4.TextString = ExaminationController.GetStringByIndex(3);
            Examination_Lable_5.TextString = ExaminationController.GetStringByIndex(4);
        }

        #endregion

    }
}
