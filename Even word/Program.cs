public class Program
{
    public static void Main()
    {
        Console.WriteLine(SolutionTerceiro("acbcbba") == 1 ? "Correto" : "Errado");
        Console.WriteLine(SolutionTerceiro("axxaxa") == 2 ? "Correto" : "Errado");
        Console.WriteLine(SolutionTerceiro("aaaa") == 0 ? "Correto" : "Errado");
    }

    internal static int SolutionTerceiro(string S)
    {
        var list = S.OrderBy(x => x).ToArray();
        int remotions = 0;
        int countLetter = 1;
        for (int i = 1; i < list.Length; i++)
        {
            if (list[i] == list[i - 1])
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