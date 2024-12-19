using System.Text;

namespace ConsoleApp1;



public interface TextConverter {
    public void ConvertCharacter(char c);
    public void ConvertFontChange(string font);
    public void ConvertParagraph();
}

public class ASCIIConverter: TextConverter {
    ASCIIText asciiText = new ASCIIText();
    public void ConvertCharacter(char c) {
        asciiText.addChar(c);
    }
    public void ConvertFontChange(string font) {}
    public void ConvertParagraph() {}
    public ASCIIText GetASCIIText() { 
        return asciiText; 
    }
}
public class TeXConverter : TextConverter {
    TeXText textext = new TeXText();
    public void ConvertCharacter(char c) {
        textext.addChar(c);

    }
    public void ConvertFontChange(string font) {
        textext.addFont(font);
    }
    public void ConvertParagraph() {
        textext.makepragraph(); 
    }
    public TeXText GetTeXText() {
        return textext;
    }
}
public class textWidgetConverter : TextConverter {
    TextWidget textwidget = new TextWidget();
    public void ConvertCharacter(char c) {
        textwidget.addChar(c);

    }
    public void ConvertFontChange(string font) {
        textwidget.addFont(font);
    }
    public void ConvertParagraph() {
        textwidget.makepragraph();
    }
    public TextWidget GetTextWidget() {
        return textwidget;
    }
}

public class RTFReader {
    private TextConverter builder;
    public RTFReader(TextConverter builder) { 
        this.builder = builder; 
    }
    public void ParseRTF(string s) {
        foreach (char c in s) {
            switch (c) {
                case '\n' :
                    builder.ConvertParagraph(); 
                    break;
                default:
                    builder.ConvertCharacter(c); 
                    break;
            }
        }
        builder.ConvertFontChange("Couriel"); 
    }
}
class Program {
    static void Main(string[] args) {
        string rtfText = "Hello, World !! \nThis Mark Magdy Mounir \n ID:2100572 .";

        // ASCII 
        ASCIIConverter asciiBuilder = new ASCIIConverter();
        RTFReader asciiReader = new RTFReader(asciiBuilder);
        asciiReader.ParseRTF(rtfText);
        Console.WriteLine("ASCII Conversion:");
        Console.WriteLine(asciiBuilder.GetASCIIText());

        // TeX 
        TeXConverter texBuilder = new TeXConverter();
        RTFReader texReader = new RTFReader(texBuilder);
        texReader.ParseRTF(rtfText);
        Console.WriteLine("TeX Conversion:");
        Console.WriteLine(texBuilder.GetTeXText());

        // Text Widget 
        textWidgetConverter widgetBuilder = new textWidgetConverter();
        RTFReader widgetReader = new RTFReader(widgetBuilder);
        widgetReader.ParseRTF(rtfText);
        Console.WriteLine("Text Widget Conversion:");
        Console.WriteLine(widgetBuilder.GetTextWidget());
    }
}

