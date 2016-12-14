using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace InputSpeedExamination
{
    public static class ExaminationController
    {

        #region 属性

        private static string examinationText = string.Empty;

        public static string ExaminationText
        {
            get
            {
                return examinationText;
            }

            set
            {
                examinationText = value;
            }
        }

        private static Font textFont;

        public static Font TextFont
        {
            get
            {
                return textFont;
            }

            set
            {
                textFont = value;
            }
        }

        private static int textAreaWidth = 0;

        public static int TextAreaWidth
        {
            get
            {
                return textAreaWidth;
            }

            set
            {
                textAreaWidth = value;
            }
        }

        #endregion

        #region TextLine 结构

        private static List<TextLine> TextLineList;

        public class TextLine
        {
            /// <summary>
            /// 测试字符串
            /// </summary>
            public string ExaminationText;

            /// <summary>
            /// 用户字符串
            /// </summary>
            public string UserText;
        }

        #endregion

        #region 方法

        /// <summary>
        /// 重置
        /// </summary>
        public static void Reset(string examination_text)
        {
            examination_text = examination_text.Replace("\r\n", "\n").Replace("\r", "\n");
            ExaminationText = examination_text;
        }

        /// <summary>
        /// 根据字体及每行宽度切割字符串
        /// </summary>
        /// <param name="font"></param>
        /// <param name="width"></param>
        public static void Spilt(Font font, int width)
        {
            TextFont = font;
            TextAreaWidth = width;
            TextLineList = new List<TextLine>();
            bool FlagNeedSpilt = false;
            int pos = 0;
            int pos_left = 0;
            int len = ExaminationText.Length;
            string temp = string.Empty;
            Bitmap b = new Bitmap(width + 100, width + 100);
            Graphics gs = Graphics.FromImage(b);
            //gs.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            while (true)
            {
                if (pos >= len && !FlagNeedSpilt)
                {
                    FlagNeedSpilt = true;
                    continue;
                }
                if (!FlagNeedSpilt && ExaminationText[pos] == '\n')
                {
                    FlagNeedSpilt = true;
                    pos++;
                    pos++;
                    continue;
                }
                if (!FlagNeedSpilt)
                {
                    temp = ExaminationText.Substring(pos_left, pos - pos_left);
                    if (GetStringWidth(temp, TextFont, gs) >= width)
                    {
                        FlagNeedSpilt = true;
                        continue;
                    }
                }
                else
                {
                    temp = ExaminationText.Substring(pos_left, pos - pos_left - 1);
                    temp = temp.Trim('\n');
                    temp = TrimAll(temp);
                    if (temp.Length != 0)
                    {
                        if (pos == len && ExaminationText[pos - 1] != '\n')
                            temp += ExaminationText[pos - 1];
                        TextLine tl = new TextLine();
                        tl.ExaminationText = temp;
                        tl.UserText = string.Empty;
                        TextLineList.Add(tl);
                    }
                    if (pos >= len)
                    {
                        break;
                    }
                    FlagNeedSpilt = false;
                    pos--;
                    pos_left = pos;
                }
                pos++;
            }
            gs.Dispose();
            b.Dispose();
        }

        /// <summary>
        /// 获取字符串行列表
        /// </summary>
        /// <returns></returns>
        public static List<TextLine> GetSpiltList()
        {
            return TextLineList;
        }

        /// <summary>
        /// 去掉首尾空格
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static string TrimAll(string str, char needTrimchr = ' ')
        {
            try
            {
                bool flag = true;
                while (true)
                {
                    flag = true;
                    if (str[0] == needTrimchr)
                    {
                        str = str.TrimStart(needTrimchr);
                        flag = false;
                    }
                    if (str[str.Length - 1] == needTrimchr)
                    {
                        str = str.TrimEnd(needTrimchr);
                        flag = false;
                    } 
                    if (flag)
                        break;
                }
                return str;
            }
            catch
            {
                return str;
            }
        }

        private static int GetStringWidth(string str, Font font, Graphics gs)
        {
            StringFormat sf = StringFormat.GenericTypographic;
            sf.FormatFlags |= StringFormatFlags.MeasureTrailingSpaces;
            var sizef = gs.MeasureString(str, font, 5000, sf);
            return (int)sizef.Width;
        }

        /// <summary>
        /// 根据索引号获取行字符串
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public static string GetStringByIndex(int index)
        {
            if (index >= TextLineList.Count)
                return string.Empty;
            else
                return TextLineList[index].ExaminationText;
        }

        #endregion

    }
}
