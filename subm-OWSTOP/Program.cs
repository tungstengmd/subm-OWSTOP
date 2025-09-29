using static System.Console;
using static System.Environment;
using System.Text.RegularExpressions;

internal class Program {
    static int Menu() {
        Write("\x1b[?1049henter a number:\n1: password checking\n2: number boundary checker\n0: quit\n% ");
        return Convert.ToInt32(ReadLine()!);
    }
    static void Main() {
        switch (Menu()) {
            case 1:
                PassCheck();
                break;
            case 2:
                Range();
                break;
            default:
                ExitCode = 0;
                break;
        }
        Write("\x1b[?1049l");
    }
    static void Range() {
        Clear();
        Write("enter a comma-separated list of numbers [1: num to check, 2: inclusive minimum, 3: inclusive maximum]\n% ");
        int[] args = Array.ConvertAll(ReadLine()!.Split(","), int.Parse);
        if (args[0] > args[1] && args[0] < args[2]) ExitCode = 0; else ExitCode = 1;
    }
    static void PassCheck() {
        Clear();
        string[] reg = { @"[a-zA-Z]", @"\W" };
        Write("enter a password [MUST BE AT LEAST 10 CHARACTERS AND MUST HAVE BOTH LETTERS AND NON-LETTERS]\n% ");
        string pass = ReadLine()!;
        ExitCode = 1;
        if (pass.Length > 9) { WriteLine("Length >= 10? TRUE"); ExitCode = 0; } else WriteLine("Length >= 10? FALSE");
        if (Regex.IsMatch(pass, reg[0])) { WriteLine("Letters? TRUE"); ExitCode = 0; } else WriteLine("Letters? FALSE");
        if (Regex.IsMatch(pass, reg[1])) { WriteLine("Non-letters? TRUE"); ExitCode = 0; } else WriteLine("Non-letters? FALSE");
    }
}
