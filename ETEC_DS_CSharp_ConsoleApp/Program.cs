using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static readonly string[] appsTable = new string[]
    {
        "Soma",
        "Subtração",
        "Divisão",
        "Multiplicação",
        "Média",
        "Antecessor",
        "Sucessor",
        "Par ou Impar",
        "Area",
        "Total de dias de vida",
        "Reajuste de salario",
        "Percentual de votos",
        "Time vencedor",
        "Aprovado ou Reprovado",
        "IMC",
        "Salario Horas Extra",
    };
    static readonly Dictionary<int, Action> programas = new Dictionary<int, Action>()
    {
        { 0, () => Soma() },
        { 1, () => Subtrair() },
        { 2, () => Dividir() },
        { 3, () => Multiplicar() },
        { 4, () => Media() },
        { 5, () => Antecessor() },
        { 6, () => Sucessor() },
        { 7, () => ParImpar() },
        { 8, () => Areas() },
        { 9, () => DiasDeVida() },
        { 10, () => ReajusteSalario() },
        { 11, () => PercentualVotos() },
        { 12, () => TimeVencedor() },
        { 13, () => AprovadoReprovado() },
        { 14, () => IMC() },
        { 15, () => Salario() },
    };

    static void Main(string[] args)
    {
        Console.WriteLine("Insira o numero correspondente ao programa que deseja utilizar.");
        Console.Write($"{MakeAppsList()}\n");

        int appIndex = Utils.GetInt("Insira sua escolha");
        if (appIndex > programas.ToArray().Length || appIndex < 0)
        {
            Console.Clear();
            Console.Write("O numero inserido não é valido");
            Main(new string[0]);
        }
        programas[appIndex]();

        Console.Write("\nDeseja reutilizar o programa? digite [y] para sim ou [n] para não:\n");
        string input = Console.ReadLine();
        if (input == "y" || input == "Y")
        {
            Console.Clear();
            Main(new string[0]);
        }

        Environment.Exit(0);
    }

    static string MakeAppsList()
    {
        string list = "";
        for (int i = 1; i <= appsTable.Length; i++)
        {
            int j = i - 1;
            if (j < 10) list += $"{j}  | ";
            else list += $"{j} | ";

            list += appsTable[j];

            if (i == 0 || i % 3 != 0)
            {
                for (int s = 0; s < Utils.Max(Utils.StringLengths(appsTable)) - appsTable[j].Length; s++)
                    list += " ";

                list += " | ";
            }
            else list += "\n";
        }
        return list;
    }

    public static void Restart()
    {
        Console.Clear();
        Console.WriteLine("Apenas NUMEROS serão aceitos!\n\n\n\n\n");
        Main(new string[0]);
    }

    #region Calculos
    /// <summary>
    /// realiza somas
    /// </summary>
    static void Soma()
    {
        double resultado = 0;

        // quantidade de numeros a serem somados
        int inputSomas = Utils.GetInt("Insira o total de numeros a serem somados");
        // verifica se o valor inserido pelo usuario é um numero
        // se sim, usa-o para criar os arrays, se não, reinicia o programa
        double[] numeros = new double[inputSomas];
        // pede para o usuario inserir os numeros a serem somados
        for (int i = 0; i < numeros.Length; i++)
        {
            if (i == 0)
                numeros[i] = Utils.GetDouble("Digite o primeiro numero para a soma");
            else
                numeros[i] = Utils.GetDouble("Digite o proximo numero para a soma");
        }
        // efetua a soma
        for (int j = 0; j < numeros.Length; j++)
            resultado += numeros[j];
        // devolve para o ususario o resultado da soma
        Console.WriteLine($"A soma dos valores é {resultado}");
    }
    /// <summary>
    /// realiza Subtrações
    /// </summary>
    static void Subtrair()
    {
        double resultado = 0;

        // quantidade de numeros a serem subtraidos
        int inputSomas = Utils.GetInt("Insira o total de numeros a serem subtraidos");
        // verifica se o valor inserido pelo usuario é um numero
        // se sim, usa-o para criar os arrays, se não, reinicia o programa
        double[] numeros = new double[inputSomas];
        // pede para o usuario inserir os numeros a serem subtraidos
        for (int i = 0; i < numeros.Length; i++)
        {
            if (i == 0)
                numeros[i] = Utils.GetDouble("Digite o primeiro numero para a subtração");
            else
                numeros[i] = Utils.GetDouble("Digite o proximo numero para a subtração");
        }
        // efetua a soma
        for (int j = 0; j < numeros.Length; j++)
            resultado -= numeros[j];
        // devolve para o ususario o resultado da soma
        Console.WriteLine($"A soma dos valores é {resultado}");
    }
    /// <summary>
    /// realiza divizões
    /// </summary>
    static void Dividir()
    {
        double resultado = 0;

        // quantidade de numeros a serem divididos
        // verifica se o valor inserido pelo usuario é um numero
        // se sim, usa-o para criar os arrays, se não, reinicia o programa
        double[] numeros = new double[Utils.GetInt("Insira o total de numeros a serem divididos")];

        // pede para o usuario inserir os numeros a serem divididos
        for (int i = 0; i < numeros.Length; i++)
        {
            if (i == 0)
                numeros[i] = Utils.GetDouble("Digite o primeiro numero para a divisão");
            else
                numeros[i] = Utils.GetDouble("Digite o proximo numero para a divisão");
        }
        // efetua a multiplicação
        for (int j = 0; j < numeros.Length; j++)
            resultado /= numeros[j];
        // devolve para o ususario o resultado da soma
        Console.WriteLine($"A divisão dos valores é {resultado}");
    }
    /// <summary>
    /// realiza multiplicações
    /// </summary>
    static void Multiplicar()
    {
        double resultado = 1;

        // quantidade de numeros a serem multiplicados
        int inputMultiplicar = Utils.GetInt("Insira o total de numeros a serem multiplicados");
        // verifica se o valor inserido pelo usuario é um numero
        // se sim, usa-o para criar os arrays, se não, reinicia o programa
        double[] numeros = new double[inputMultiplicar];
        // pede para o usuario inserir os numeros a serem multiplicados
        for (int i = 0; i < numeros.Length; i++)
        {
            if (i == 0)
                numeros[i] = Utils.GetInt("Digite o primeiro numero para a multiplicação");
            else
                numeros[i] = Utils.GetInt("Digite o proximo numero para a multiplicação");
        }
        // efetua a multiplicação
        for (int j = 0; j < numeros.Length; j++)
            resultado *= numeros[j];
        // devolve para o ususario o resultado da soma
        Console.WriteLine($"A multiplicação dos valores é {resultado}");
    }
    /// <summary>
    /// calcula médias
    /// </summary>
    static void Media()
    {
        double resultado = 0;

        // quantidade de numeros a serem usados no calculo da média
        int numerosParaMedia = Utils.GetInt("Insira quantas notas serão calculadas para obter a média");
        // verifica se o valor inserido pelo usuario é um numero
        // se sim, usa-o para criar os arrays, se não, reinicia o programa
        double[] numeros = new double[numerosParaMedia];
        // pede para o usuario inserir os numeros a serem somados
        for (int i = 0; i < numeros.Length; i++)
        {
            if (i == 0) numeros[i] = Utils.GetDouble("Digite o primeiro numero para a média");
            else numeros[i] = Utils.GetDouble("Digite o proximo numero para a média");
        }
        // calcula a média
        for (int j = 0; j < numeros.Length; j++)
        {
            resultado += numeros[j];
        }
        // devolve para o usuario a média calculada
        Console.WriteLine($"A média é {resultado / numeros.Length}");
    }
    /// <summary>
    /// calcula o antecessor de um numero
    /// </summary>
    static void Antecessor()
    {
        int numero = Utils.GetInt("Insira um numero para que o antecessor seja calculado");
        Console.WriteLine($"O antecessor de {numero} é {numero - 1}");
    }
    /// <summary>
    /// calcula o sucessor de um numero
    /// </summary>
    static void Sucessor()
    {
        int numero = Utils.GetInt("Insira um numero para que o sucessor seja calculado");
        Console.WriteLine($"O sucessor de {numero} é {numero + 1}");
    }
    /// <summary>
    /// calcula se o numero é par ou impar
    /// </summary>
    static void ParImpar()
    {
        int numero = Utils.GetInt("Insira o numero a ser calculado");

        if (numero % 2 == 0)
        {
            Console.WriteLine($"{numero} é par");
            return;
        }

        Console.WriteLine($"{numero} é impar");
    }
    /// <summary>
    /// calcula a area de diferentes formas geometricas
    /// </summary>
    static void Areas()
    {
        double formaBase, formaAltura;
        string[] formas = new string[]
        {
                "Area do triangulo = 0",
                "Area do quadrado/retangulo = 1",
        };

        Console.Write("Insira o numero correspondente ao calculo que deseja");

        foreach (string s in formas)
            Console.WriteLine(s);

        int forma = Utils.GetInt("Insira sua escolha");

        switch (forma)
        {
            case 0:
                formaBase = Utils.GetDouble("Insira o tamanho da base do triangulo");
                formaAltura = Utils.GetDouble("Insira a altura do triangulo");
                Console.WriteLine($"A area do triangulo é {(formaBase * formaAltura) / 2}");
                break;
            case 1:
                formaBase = Utils.GetDouble("Insira o tamanho da base do quadrado / retangulo");
                formaAltura = Utils.GetDouble("Insira a altura do quadrado / retangulo");
                Console.WriteLine($"A area do quadrado/retangulo é {formaBase * formaAltura}");
                break;
        }
    }
    /// <summary>
    /// calcula dias de vida baseado em anos, meses e dias
    /// </summary>
    static void DiasDeVida()
    {
        // pede para que o usuario insira sua idade em anos
        int anos = Utils.GetInt("Insira quantos anos de vida você possui");
        // pede para que o usuario insira a quantidade de meses des de seu ultimo aniverssario
        int meses = Utils.GetInt("Insira a quantidade de meses des de seu ultimo aniverssario");
        // pede para que o usuario insira a quantidade de dias des de o ultimo mes
        int dias = Utils.GetInt("Insira o dia do mês");
        // devolve ao usuario sua idade em dias
        Console.WriteLine($"Você possui um total de {(anos * 365) + (meses * 30) + dias + (meses / 2)} dias de vida.");
    }
    /// <summary>
    /// calcula reajuste de salario
    /// </summary>=
    static void ReajusteSalario()
    {
        // pede para que o ususario insira o salario mensal atual
        double salario = Utils.GetInt("Insira seu salario mensal atual");
        // pede para que o ususario insira o percentual de aumento do salario
        double reajustePercentual = Utils.GetInt("Insira o percentual de almento do salario");
        // devolve para o usuario o valor do novo salairo
        Console.WriteLine($"Seu novo salario sera de {salario + ((salario * reajustePercentual) / 100)}");
    }
    /// <summary>
    /// percentual de votos
    /// </summary>
    static void PercentualVotos()
    {
        // pede para que o usuario insira o numero de votos em branco
        int votosBrancos = Utils.GetInt("Insita o total de votos em branco");
        // pede para que o usuario insira o numero de votos nulos
        int votosNulos = Utils.GetInt("Insita o total de votos nulos");
        // pede para que o usuario insira o numero de votos validos
        int votosValidos = Utils.GetInt("Insita o total de votos validos");
        // calcula o total de votos
        int votosTotal = votosBrancos + votosNulos + votosValidos;
        // devolve para o usuario a porcentagem correspondente a cada tipo de voto
        Console.WriteLine($"Os votos em branco foram {votosTotal * votosBrancos / 100}% do total");
        Console.WriteLine($"Os votos nulos foram {votosTotal * votosNulos / 100}% do total");
        Console.WriteLine($"Os votos validos foram {votosTotal * votosValidos / 100}% do total");
    }
    /// <summary>
    /// calcula qual time venceu baseado na quantidade de pontos
    /// </summary>
    static void TimeVencedor()
    {
        string[] timeNomes = new string[2];
        int[] timePontos = new int[2];

        Console.WriteLine("Insira o nome do primeiro time");
        timeNomes[0] = Console.ReadLine();

        Console.WriteLine("Insira o nome do segundo time");
        timeNomes[1] = Console.ReadLine();

        timePontos[0] = Utils.GetInt("Insira a quantidade de pontos do primeiro time");

        timePontos[1] = Utils.GetInt("Insira a quantidade de pontos do segundo time");

        if (timePontos[0] > timePontos[1])
        {
            Console.WriteLine($"O time {timePontos[0]} ganhou!");
            return;
        }
        else if (timePontos[1] > timePontos[0])
        {
            Console.WriteLine($"O time {timePontos[1]} ganhou!");
            return;
        }
        Console.WriteLine("Houve um empate!");
    }
    /// <summary>
    /// calcula a media de um aluno
    /// </summary>
    static void AprovadoReprovado()
    {
        int provas = Utils.GetInt("Insira a quantidade de provas a serem contadas");
        float resultado = 0;
        float[] notas = new float[provas];
        Console.WriteLine("Insira suas notas");
        for (int i = 0; i < provas; i++)
        {
            if (i == 0)
                notas[i] = Utils.GetFloat("Insira a primeira nota");
            else
                notas[i] = Utils.GetFloat("Insira a proxima nota");
        }
        for (int i = 0; i < provas; i++)
            resultado += notas[i];
        resultado /= provas;

        if (resultado >= 7)
            Console.WriteLine($"Sua média foi {resultado}. Aprovado");
        else if (resultado < 7 && resultado >= 5)
            Console.WriteLine($"Sua média foi {resultado}. Recuperação");
        else
            Console.WriteLine($"Sua média foi {resultado}. Reprovado");
    }
    /// <summary>
    /// calcula o IMC
    /// </summary>
    static void IMC()
    {
        string[] imcTable = new string[]{
                "abaixo de 17 - muito abaixo do peso",
                "17 a 18.99 - abaixo do peso",
                "19 a 24.99 - peso ideal",
                "25 a 29.99 - sobrepeso",
                "30 a 34.99 - obesidade",
                "35 a 40 - obesidade severa",
                "acima de 40 - obesidade morbida"
            };
        float massa = Utils.GetFloat("Insira seu peso em quilos");
        int altura = Utils.GetInt("Insira sua altura em metros sem ponto ou virgula");
        float resultado = massa / ((altura / 100) ^ 2);

        Console.WriteLine($"\nSeu IMC é de {resultado}");

        if (resultado < 17)
            Console.WriteLine(imcTable[0]);
        else if (resultado > 17 && resultado < 18.99f)
            Console.WriteLine(imcTable[1]);
        else if (resultado > 19 && resultado < 24.99f)
            Console.WriteLine(imcTable[2]);
        else if (resultado > 25 && resultado < 29.99f)
            Console.WriteLine(imcTable[3]);
        else if (resultado > 30 && resultado < 34.99f)
            Console.WriteLine(imcTable[4]);
        else if (resultado > 35 && resultado < 39.99f)
            Console.WriteLine(imcTable[5]);
        else
            Console.WriteLine(imcTable[6]);
    }
    /// <summary>
    /// Calcula o salario com horas extra
    /// </summary>
    static void Salario()
    {
        float horasSemanais = Utils.GetFloat("Insira a quantidade base de horas de trabalho semanais");
        int semanas = Utils.GetInt("Insira quantas semanas voce trabalhou no mês");
        float horasExtra = Utils.GetFloat("Insira a quantidade de horas extra trabalhadas");
        float salario = Utils.GetFloat("Insira quanto voce recebe por hora trabalhada");
        float salarioFinal = (salario * horasSemanais * semanas) + ((salario * 1.5f) * horasExtra);

        Console.WriteLine($"Seu salario final será de {salarioFinal}");
    }
    #endregion
}