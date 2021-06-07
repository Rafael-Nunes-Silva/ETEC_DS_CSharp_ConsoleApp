using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum TabelaType
{
    BASIC,
    ENUMERATED,
}
public class Utils
{
    /// <summary>
    /// Retorna verdadeiro se for um numero e falso se for algum outro caractere
    /// </summary>
    public static bool VerificarNumero(string input)
    {
        string[] caracteres = new string[]{
                "a", "A", "b", "B", "c", "C",
                "d", "D", "e", "E", "f", "F",
                "g", "G", "h", "H", "i", "I",
                "j", "J", "k", "K", "l", "L",
                "m", "M", "n", "N", "o", "O",
                "p", "P", "q", "Q", "r", "R",
                "s", "S", "t", "T", "u", "U",
                "v", "V", "w", "W", "x", "X",
                "y", "Y", "z", "Z", "ç", "Ç",
                "!", "@", "#", "$", "%", "&",
                "*", "(", ")", "[", "]", "{",
                "}", "?", ":", ";", "<", ">",
                ",", ".", "/", "'", "|", "-",
                "°", "¹", "²", "³", "£", "¢",
                "¬", "+", "=", "_", "§", "ª"
            };

        foreach (string caractere in caracteres)
        {
            if (input == caractere)
            {
                Program.Restart(true, "Apenas NUMEROS serão aceitos!");
                return false;
            }
        }

        return true;
    }
    /// <summary>
    /// Retorna um valor aleatorio entre um valor minimo e maximo do tipo int
    /// </summary>
    public static int GetRandom(int min, int max)
    {
        Random rand = new Random();
        return rand.Next(min, max+1);
    }
    /// <summary>
    /// Retorna um valor booleano aleatorio
    /// </summary>
    public static bool GetRandom()
    {
        Random rand = new Random();

        if (rand.Next(0, 2) == 0)
            return false;

        return true;
    }
    /// <summary>
    /// Retorna uma string formatada como uma tabela numerada ou não
    /// </summary>
    public static string FormatTable(string[] data, int collumns, TabelaType type = TabelaType.BASIC)
    {
        string list = "";
        for (int i = 1; i <= data.Length; i++)
        {
            int j = i - 1;
            switch (type)
            {
                case TabelaType.BASIC:
                    list += $" - ";
                    break;
                case TabelaType.ENUMERATED:
                    if (j < 10) list += $" {j}  | ";
                    else list += $" {j} | ";
                    break;
            }

            list += data[j];

            if (i == 0 || i % collumns != 0)
            {
                for (int s = 0; s < Utils.Max(Utils.StringLengths(data)) - data[j].Length; s++)
                    list += " ";

                list += "|";
            }
            else list += "\n";
        }
        return list;
    }
    /// <summary>
    /// Retorna o valor maximo num array de tipo int
    /// </summary>
    public static int Max(int[] numeros)
    {
        int max = 0;
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] > max)
                max = numeros[i];
        }
        return max;
    }
    /// <summary>
    /// Retorna o valor maximo num array de tipo float
    /// </summary>
    public static float Max(float[] numeros)
    {
        float max = 0;
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] > max)
                max = numeros[i];
        }
        return max;
    }
    /// <summary>
    /// Retorna o valor maximo num array de tipo double
    /// </summary>
    public static double Max(double[] numeros)
    {
        double max = 0;
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] > max)
                max = numeros[i];
        }
        return max;
    }
    /// <summary>
    /// Retorna o valor minimo num array de tipo int
    /// </summary>
    public static int Min(int[] numeros)
    {
        int min = Int32.MaxValue;
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] < min)
                min = numeros[i];
        }
        return min;
    }
    /// <summary>
    /// Retorna o valor minimo num array de tipo float
    /// </summary>
    public static float Min(float[] numeros)
    {
        float min = float.MaxValue;
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] < min)
                min = numeros[i];
        }
        return min;
    }
    /// <summary>
    /// Retorna o valor minimo num array de tipo double
    /// </summary>
    public static double Min(double[] numeros)
    {
        double min = double.MaxValue;
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] < min)
                min = numeros[i];
        }
        return min;
    }
    /// <summary>
    /// Retorna o valor inserido convertido em int
    /// </summary>
    public static int GetInt(string message = "")
    {
        Console.Write($"{message}: ");
        string input = Console.ReadLine();
        VerificarNumero(input);
        return Convert.ToInt32(input);
    }
    /// <summary>
    /// Retorna o valor inserido convertido em float
    /// </summary>
    public static float GetFloat(string message = "")
    {
        Console.Write($"{message}: ");
        string input = Console.ReadLine();
        VerificarNumero(input);
        return (float)Convert.ToDouble(input);
    }
    /// <summary>
    /// Retorna o valor inserido convertido em double
    /// </summary>
    public static double GetDouble(string message = "")
    {
        Console.Write($"{message}: ");
        string input = Console.ReadLine();
        VerificarNumero(input);
        return Convert.ToDouble(input);
    }
    /// <summary>
    /// Retorna uma lista com os comprimentos de cada string de uma lista
    /// </summary>
    public static int[] StringLengths(string[] s)
    {
        int[] i = new int[s.Length];
        for (int j = 0; j < s.Length; j++)
            i[j] = s[j].Length;
        return i;
    }
    /// <summary>
    /// Retorna uma string invertida
    /// </summary>
    public static string InvertString(string s)
    {
        string result = "";

        for (int i = 1; i <= s.Length; i++)
            result += s[s.Length - i];

        return result;
    }
    /// <summary>
    /// Retorna uma lista reorganizada to tipo int
    /// </summary>
    public static int[] Reorganize(int[] numeros)
    {
        List<int> n = new List<int>();
        for (int i = 0; i < numeros.Length; i++)
            n.Add(numeros[i]);
        n.Sort();
        return n.ToArray();
    }
    /// <summary>
    /// Retorna uma lista reorganizada to tipo float
    /// </summary>
    public static float[] Reorganize(float[] numeros)
    {
        List<float> n = new List<float>();
        for (int i = 0; i < numeros.Length; i++)
            n.Add(numeros[i]);
        n.Sort();
        return n.ToArray();
    }
    /// <summary>
    /// Retorna uma lista reorganizada to tipo double
    /// </summary>
    public static double[] Reorganize(double[] numeros)
    {
        List<double> n = new List<double>();
        for (int i = 0; i < numeros.Length; i++)
            n.Add(numeros[i]);
        n.Sort();
        return n.ToArray();
    }
}