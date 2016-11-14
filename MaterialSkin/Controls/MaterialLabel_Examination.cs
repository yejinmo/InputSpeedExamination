using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MaterialSkin.Controls
{
    public class MaterialLabel_Examination : Label, IMaterialControl
    {
        [Browsable(false)]
        public int Depth { get; set; }
        [Browsable(false)]
        public MaterialSkinManager SkinManager { get { return MaterialSkinManager.Instance; } }
        [Browsable(false)]
        public MouseState MouseState { get; set; }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            ForeColor = SkinManager.GetPrimaryTextColor();
            Font = SkinManager.FONT_SIZE_26;

            BackColorChanged += (sender, args) => ForeColor = SkinManager.GetPrimaryTextColor();
        }

        #region Examination

        private Color correctForeColor = Color.Black;
        public Color CorrectForeColor
        {
            get
            {
                return correctForeColor;
            }
            set
            {
                correctForeColor = value;
                Invalidate();
            }
        }

        private Color errorForeColor = Color.Red;
        public Color ErrorForeColor
        {
            get
            {
                return errorForeColor;
            }
            set
            {
                errorForeColor = value;
                Invalidate();
            }
        }

        private string textFieldString = string.Empty;
        public string TextFieldString
        {
            get
            {
                return textFieldString;
            }
            set
            {
                textFieldString = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            var UserStringArray = TextFieldString.ToCharArray();
            var AnswerStringArray = Text.ToCharArray();
            int Len_UserStringArray = UserStringArray.Length;
            int Len_AnswerStringArray = AnswerStringArray.Length;
            int i = 0;
            float pos_left = 0;
            g.Clear(BackColor);
            while (true)
            {
                var size = GetStringWidth(AnswerStringArray[i].ToString());
                if (i == Len_UserStringArray)
                    g.DrawString(AnswerStringArray[i].ToString(), SkinManager.FONT_SIZE_26, new SolidBrush(Color.Green), new PointF(pos_left, 0));
                else if (i > Len_UserStringArray)
                    g.DrawString(AnswerStringArray[i].ToString(), SkinManager.FONT_SIZE_26, new SolidBrush(ForeColor), new PointF(pos_left, 0));
                else
                {
                    if (AnswerStringArray[i] == UserStringArray[i])
                        g.DrawString(AnswerStringArray[i].ToString(), SkinManager.FONT_SIZE_26, new SolidBrush(CorrectForeColor), new PointF(pos_left, 0));
                    else
                        g.DrawString(AnswerStringArray[i].ToString(), SkinManager.FONT_SIZE_26, new SolidBrush(ErrorForeColor), new PointF(pos_left, 0));
                }
                pos_left += size.Width;
                ++i;
                if (i >= Len_AnswerStringArray)
                    break;

            }
        }

        private SizeF GetStringWidth(string str)
        {
            Graphics gs = CreateGraphics();
            var sizef = gs.MeasureString(str, Font, 1000, StringFormat.GenericTypographic);
            gs.Dispose();
            return sizef;
        }

        #endregion

    }
}
