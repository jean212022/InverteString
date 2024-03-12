using static System.Console;

namespace InversaoString;

public class Program
{
    public static void Inverte(ref string? str)
    {
        string reverso = "";
        for(int i = str.Length - 1; i >= 0; i--)
        {
            reverso += str[i];
        }
        str = reverso;
    }

    public static void Main()
    {
        WriteLine("\tInverte Strings:");
        resp:
        Write("Digite uma string: "); string? str = ReadLine(); 
        if(string.IsNullOrEmpty(str))
        {
            WriteLine("Erro!\nInforme um valor compátivel!");
            goto resp;
        }
        string? inverso = str; Inverte(ref inverso);
        WriteLine("O inverso da string {0} é {1}!", str, inverso);
    }
}