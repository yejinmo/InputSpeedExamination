﻿using System;
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

        private new string Text;

        private string textString = string.Empty;
        public string TextString
        {
            get
            {
                return textString;
            }
            set
            {
                textString = value;
                Invalidate();
                OnBindingLabelTextChanged(new EventArgs());
            }
        }

        private bool drawNextCharHint = false;
        public bool DrawNextCharHint
        {
            get
            {
                return drawNextCharHint;
            }

            set
            {
                drawNextCharHint = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            var UserStringArray = TextFieldString.ToCharArray();
            var AnswerStringArray = TextString.ToCharArray();
            int Len_UserStringArray = UserStringArray.Length;
            int Len_AnswerStringArray = AnswerStringArray.Length;
            int i = 0;
            float pos_left = 0;
            g.Clear(BackColor);
            if (Len_UserStringArray == 0 && Len_AnswerStringArray == 0)
                return;
            while (true)
            {
                char chr = AnswerStringArray[i];
                var size = GetStringWidth(chr.ToString());
                if (DrawNextCharHint && i == Len_UserStringArray)
                    g.DrawString(chr.ToString(), SkinManager.FONT_SIZE_26, new SolidBrush(Color.Lime), new PointF(pos_left, 0));
                else if (i > Len_UserStringArray || (!DrawNextCharHint && i >= Len_UserStringArray))
                    g.DrawString(chr.ToString(), SkinManager.FONT_SIZE_26, new SolidBrush(ForeColor), new PointF(pos_left, 0));
                else
                {
                    if (AnswerStringArray[i] == UserStringArray[i])
                        g.DrawString(chr.ToString(), SkinManager.FONT_SIZE_26, new SolidBrush(CorrectForeColor), new PointF(pos_left, 0));
                    else
                        g.DrawString(chr.ToString(), SkinManager.FONT_SIZE_26, new SolidBrush(ErrorForeColor), new PointF(pos_left, 0));
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
            StringFormat sf = StringFormat.GenericTypographic;
            sf.FormatFlags |= StringFormatFlags.MeasureTrailingSpaces;
            var sizef = gs.MeasureString(str, Font, 1000, sf);
            gs.Dispose();
            return sizef;
        }

        public delegate void ChangedEventHandler(object sender, EventArgs e);

        public event ChangedEventHandler BindingLabelTextChanged;

        protected virtual void OnBindingLabelTextChanged(EventArgs e)
        {
            BindingLabelTextChanged?.Invoke(this, e);
        }

        #endregion

    }
}
