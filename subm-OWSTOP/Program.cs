using static System.Console;
using System.Text.RegularExpressions;

namespace subm_OWSTOP {
    internal class Program {
        static void Main(string[] args) {
            Write("enter a number\n% ");
            WriteLine(range(Convert.ToInt32(ReadLine()!), 6, 14));
            WriteLine(passcheck(ReadLine()!)); 
        }
        static int range(int num, int min, int max) {
            if (num > min && num < max) return 0;
            return 1;
        }
        static int passcheck(string pass) {
            Regex reg = new Regex(@"[a-zA-Z]|(\W)");
            Write("enter a password [MUST BE AT LEAST 10 CHARACTERS AND MUST HAVE BOTH LETTERS AND NON-LETTERS]\n% ");
            if (pass.Length > 9 && reg.IsMatch(pass)) return 0;
            return 1;
        }
    }
}
