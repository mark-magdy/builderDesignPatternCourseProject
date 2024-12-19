using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    public class TeXText {
        private StringBuilder textext = new StringBuilder();
        /*private string font;
        public string Font {
            get { return font; }
            set { font = value ; }
        }*/
        public TeXText() { }
        public TeXText(string text) {
            textext.Append(text);
        }
        public void addChar(char c) {
            textext.Append(c);
        }
        public void addFont(string font ) {
            textext.Append($"{{\\font {font}}}");
        }
        public void makepragraph() {
            textext.Append("\\par ");

        }
        public override string ToString() {
            return textext.ToString();
        }
    }
}
