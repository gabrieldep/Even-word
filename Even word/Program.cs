namespace EvenWord
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(Solution("acbcbba") == 1 ? "Correto" : "Errado");
            Console.WriteLine(Solution("axxaxa") == 2 ? "Correto" : "Errado");
            Console.WriteLine(Solution("aaaa") == 0 ? "Correto" : "Errado");
        }

        internal static int Solution(string S)
        {
            int remotions = 0;
            var arrInt = new int[26];
            for (int i = 0; i < S.Length; i++)
                arrInt[S[i] - 97]++;

            for (int i = 0; i < 26; i++)
                if (arrInt[i] % 2 == 1)
                    remotions++;
            return remotions;
        }

        internal static int SolutionReserva(string S)
        {
            string sortedWord = string.Concat(S.OrderBy(c => c));
            int remotions = 0;
            int countLetter = 1;
            for (int i = 1; i < sortedWord.Length; i++)
            {
                if (sortedWord[i] == sortedWord[i - 1])
                    countLetter++;
                else if (countLetter % 2 != 0)
                {
                    remotions++;
                    countLetter = 1;
                }
            }
            return countLetter % 2 != 0 ? ++remotions : remotions;
        }
    }
}