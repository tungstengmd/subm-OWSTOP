using System.Text.RegularExpressions;

namespace subm_OWSTOP {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("enter a number\n% ");
            Console.WriteLine(range(Convert.ToInt32(Console.ReadLine()!), 6, 14));
            Console.WriteLine(passcheck(Console.ReadLine()!)); 
        }
        static int range(int num, int min, int max) {
            if (num > min && num < max) return 0;
            return 1;
        }
        static int passcheck(string pass) {
            Regex reg = new Regex(@"[a-zA-Z]|(\W)");
            Console.Write("enter a password [MUST BE AT LEAST 10 CHARACTERS AND MUST HAVE BOTH LETTERS AND NON-LETTERS]\n% ");
            if (pass.Length > 9 && reg.IsMatch(pass)) return 0;
            return 1;
        }
    }
}
