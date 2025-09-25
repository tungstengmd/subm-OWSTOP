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
                Write(PassCheck(ReadLine()!));
                break;
            case 2:
                Write(Range());
                break;
            default:
                ExitCode = 0;
                break;
        }
        Write("\x1b[?1049h");
    }
    static int Range() {
        Clear();
        Write("enter a comma-separated list of numbers [1: num to check, 2: inclusive minimum, 3: inclusive maximum]\n% ");
        int[] args = Array.ConvertAll(ReadLine()!.Split(","), int.Parse);
        if (args[0] > args[1] && args[0] < args[2]) return 0;
        ExitCode = 1;
        return ExitCode;
    }
    static int PassCheck(string pass) {
        Clear();
        Regex reg = new Regex(@"[a-zA-Z]|(\W)");
        Write("enter a password [MUST BE AT LEAST 10 CHARACTERS AND MUST HAVE BOTH LETTERS AND NON-LETTERS]\n% ");
        if (pass.Length > 9 && reg.IsMatch(pass)) return 0;
        return 1;
    }
}
