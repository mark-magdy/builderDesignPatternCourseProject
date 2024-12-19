using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1 {
    public class TextWidget {
        StringBuilder textwidget = new StringBuilder(); 
        public TextWidget() { }
        public void addChar(char c) {
            textwidget.Append(c);
        }
        public void addFont(string font) {
            textwidget.Append($"[Font: {font}]");
        }
        public void makepragraph() {
            textwidget.Append("[PARA]");
        }
        public override string ToString() {
            return textwidget.ToString();
        }

    }
}
