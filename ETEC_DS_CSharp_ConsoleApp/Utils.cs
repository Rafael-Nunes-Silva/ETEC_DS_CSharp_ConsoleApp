using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Utils
{   
    /// <summary>
    /// retorna verdadeiro se for um numero e falso se for algum outro caractere
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
                "y", "Y", "z", "Z",
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
                Program.Restart();
                return false;
            }
        }

        return true;
    }
    /// <summary>
    /// retorna o valor maximo num array de tipo int
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
    /// retorna o valor minimo num array de tipo int
    /// </summary>
    public static int Min(int[] numeros)
    {
        int min = 0;
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] < min)
                min = numeros[i];
        }
        return min;
    }
    /// <summary>
    /// retorna o valor inserido convertido em int
    /// </summary>
    public static int GetInt(string message = "Proximo")
    {
        Console.Write($"{message}: \n");
        string input = Console.ReadLine();
        VerificarNumero(input);
        return Convert.ToInt32(input);
    }
    /// <summary>
    /// retorna o valor inserido convertido em float
    /// </summary>
    public static float GetFloat(string message = "Proximo")
    {
        Console.Write($"{message}: \n");
        string input = Console.ReadLine();
        VerificarNumero(input);
        return (float)Convert.ToDouble(input);
    }
    /// <summary>
    /// retorna o valor inserido convertido em double
    /// </summary>
    public static double GetDouble(string message = "Proximo")
    {
        Console.Write($"{message}: \n");
        string input = Console.ReadLine();
        VerificarNumero(input);
        return Convert.ToDouble(input);
    }
    /// <summary>
    /// retorna uma lista com os comprimentos de cada string da lista inserida
    /// </summary>
    public static int[] StringLengths(string[] s)
    {
        int[] i = new int[s.Length];
        for (int j = 0; j < s.Length; j++)
            i[j] = s[j].Length;
        return i;
    }
}