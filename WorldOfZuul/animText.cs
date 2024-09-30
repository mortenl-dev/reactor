using static System.Console;
public class animText {
    public animText(string input) {
        WriteLine("");
        for (int i = 0; i < input.Length;++i) {
            Write(input[i]);
            Thread.Sleep(25); //any value below 100 doesnt show up in the editor, but works in command line
        }
        WriteLine("");
    }
    public animText(string input, int delay) {
        WriteLine("");
        for (int i = 0; i < input.Length;++i) {
            Write(input[i]);
            Thread.Sleep(delay); //other version of method with controllable speed
        }
    }
    
    
}