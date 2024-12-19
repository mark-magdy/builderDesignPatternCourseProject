using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    public class ASCIIText {
        private StringBuilder asciiText = new StringBuilder();
        public ASCIIText () {}
        public ASCIIText (string text) {
            asciiText.Append (text);
        }
        public void addChar (char c) {
            asciiText.Append (c);
        }
        public override string ToString() {
            return asciiText.ToString();
        }
    }
}
