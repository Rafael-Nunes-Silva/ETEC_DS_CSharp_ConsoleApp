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
        "Venda de Combustiveis",
        "Igualdade entre numeros",
        "Ira viajar",
        "Contador",
        "Converter Binario/Decimal",
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
        { 16, () => Combustiveis() },
        { 17, () => IgualdadeNumeros() },
        { 18, () => IraViajar() },
        { 19, () => Contador()},
        { 20, () => DecimalBinario() },
    };

    static void Main(string[] args)
    {
        Console.WriteLine("Insira o numero correspondente ao programa que deseja utilizar.");
        Console.Write($"{Utils.FormatTable(appsTable, 4, TabelaType.ENUMERATED)}\n");

        int appIndex = Utils.GetInt("Insira sua escolha");
        if (appIndex > programas.ToArray().Length || appIndex < -1)
        {
            if (appIndex == -1) Environment.Exit(0);
            Console.Clear();
            Console.Write("O numero inserido não é valido\n\n\n");
            Main(new string[0]);
        }

        Console.Clear();
        programas[appIndex]();

        Console.Write("\nDeseja reutilizar o programa? digite [y] para sim ou [n] para não:\n");
        string input = Console.ReadLine();
        if (input == "y" || input == "Y")
            Restart();

        Environment.Exit(0);
    }
    /// <summary>
    /// reinicia a aplicação com um código de erro ou não
    /// </summary>
    public static void Restart(bool erro = false, string err = "")
    {
        Console.Clear();
        if (!erro)
            Main(new string[0]);
        Console.WriteLine($"{err}!\n\n\n\n\n");
        Main(new string[0]);
    }

    #region Calculos
    /// <summary>
    /// realiza somas
    /// </summary>
    static void Soma()
    {
        double resultado = 0;

        int inputSomas = Utils.GetInt("Insira o total de numeros a serem somados");

        double[] numeros = new double[inputSomas];

        for (int i = 0; i < numeros.Length; i++)
            numeros[i] = Utils.GetDouble($"Digite o {i+1}º valor para a soma");

        for (int j = 0; j < numeros.Length; j++)
            resultado += numeros[j];

        Console.WriteLine($"A soma dos valores é {resultado}");
    }
    /// <summary>
    /// realiza Subtrações
    /// </summary>
    static void Subtrair()
    {
        double resultado = 0;

        int inputSomas = Utils.GetInt("Insira o total de numeros a serem subtraidos");

        double[] numeros = new double[inputSomas];

        for (int i = 0; i < numeros.Length; i++)
            numeros[i] = Utils.GetDouble($"Digite o {i+1}º valor para a subtração");
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

        double[] numeros = new double[Utils.GetInt("Insira o total de numeros a serem divididos")];

        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = Utils.GetDouble($"Digite o {i+1}º valor para a divisão");

            if(numeros[i] == 0)
            {
                Console.WriteLine("Não é possivel fazer divisões por 0");
                i--;
                continue;
            }
        }

        for (int j = 0; j < numeros.Length-1; j++)
            resultado += numeros[j] / numeros[j+1];

        Console.WriteLine($"A divisão dos valores é {resultado}");
    }
    /// <summary>
    /// realiza multiplicações
    /// </summary>
    static void Multiplicar()
    {
        double resultado = 1;

        int inputMultiplicar = Utils.GetInt("Insira o total de numeros a serem multiplicados");

        double[] numeros = new double[inputMultiplicar];

        for (int i = 0; i < numeros.Length; i++)
            numeros[i] = Utils.GetInt($"Digite o {i+1}º valor para a multiplicação");

        for (int j = 0; j < numeros.Length; j++)
            resultado *= numeros[j];

        Console.WriteLine($"A multiplicação dos valores é {resultado}");
    }
    /// <summary>
    /// calcula médias
    /// </summary>
    static void Media()
    {
        double resultado = 0;

        int numerosParaMedia = Utils.GetInt("Insira quantas notas serão calculadas para obter a média");

        double[] numeros = new double[numerosParaMedia];

        for (int i = 0; i < numeros.Length; i++)
            numeros[i] = Utils.GetDouble($"Digite o {i+1}º valor para a média");

        for (int j = 0; j < numeros.Length; j++)
            resultado += numeros[j];

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

        Console.WriteLine((numero % 2 == 0) ? $"{numero} é par" : $"{numero} é impar");
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

        Console.WriteLine(Utils.FormatTable(formas, 1, TabelaType.ENUMERATED));

        switch (Utils.GetInt("Insira sua escolha"))
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
        int anos = Utils.GetInt("Insira quantos anos de vida você possui");
        int meses = Utils.GetInt("Insira a quantidade de meses des de seu ultimo aniverssario");
        int dias = Utils.GetInt("Insira o dia do mês");

        Console.WriteLine($"Você possui um total de {(anos * 365) + (meses * 30) + dias + (meses / 2)} dias de vida.");
    }
    /// <summary>
    /// calcula reajuste de salario
    /// </summary>=
    static void ReajusteSalario()
    {
        double salario = Utils.GetInt("Insira seu salario mensal atual");
        double reajustePercentual = Utils.GetInt("Insira o percentual de almento do salario");

        Console.WriteLine($"Seu novo salario sera de {salario + ((salario * reajustePercentual) / 100)}");
    }
    /// <summary>
    /// percentual de votos
    /// </summary>
    static void PercentualVotos()
    {
        int votosBrancos = Utils.GetInt("Insita o total de votos em branco");
        int votosNulos = Utils.GetInt("Insita o total de votos nulos");
        int votosValidos = Utils.GetInt("Insita o total de votos validos");
        int votosTotal = votosBrancos + votosNulos + votosValidos;

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
            notas[i] = Utils.GetFloat($"Insira a {i+1}º nota");

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
        float resultado = (massa / ((altura / 100) ^ 2));

        Console.WriteLine($"\nSeu IMC é {resultado}");

        Console.WriteLine($"\n{Utils.FormatTable(imcTable, 2)}");
    }
    /// <summary>
    /// Calcula o salario com horas extra
    /// </summary>
    static void Salario()
    {
        float horasMensais = Utils.GetFloat("Insira a quantidade de horas de trabalho mensais");
        float horasExtra = Utils.GetFloat("Insira a quantidade de horas extra trabalhadas");
        float salario = Utils.GetFloat("Insira quanto voce recebe por hora trabalhada");
        float salarioFinal = (salario * horasMensais) + ((salario * 1.5f) * horasExtra);

        Console.WriteLine($"Seu salario é de {salario * horasMensais}.");
        Console.WriteLine($"Acrecentados {(salario * 1.5f) * horasExtra} pelas {horasExtra} horas extra.");
        Console.WriteLine($"O total é de {salarioFinal}.");
    }
    /// <summary>
    /// Simula uma venda de combustiveis
    /// </summary>
    static void Combustiveis()
    {
        string[] tabelaPreços = new string[]
        {
            "Gasolina - R$ 3,30",
            "Álcool - R$ 2,90"
        };
        string[] tabelaDescontos = new string[]
        {
            "3% até 20 litros de Álcool",
            "5% acima de 20 litros de Álcool",
            "4% até 20 litros de Gasolina",
            "6% acima de 20 litros de Gasolina",
        };

        Console.WriteLine("Tabela de preços:");
        Console.Write($"{Utils.FormatTable(tabelaPreços, 2)}\n");
        Console.WriteLine("Tabela de descontos:");
        Console.Write($"{Utils.FormatTable(tabelaDescontos, 2)}\n");
        Console.WriteLine("Insira o tipo de combustivel desejado ('A' - álcool, 'G' - gasolina)");

        string combTipo = Console.ReadLine();
        if (combTipo != "A" && combTipo != "a" && combTipo != "G" && combTipo != "g")
            Restart(true, "Letra inserida INVALIDA!");

        float litros = Utils.GetFloat("Insira quantos litros deseja");
        double valorTotal = 0;

        if (litros <= 20)
        {
            if (combTipo == "A" || combTipo == "a")
                valorTotal = litros * (2.9 - (2.9 * 0.03));
            else
                valorTotal = litros * (3.3 - (3.3 * 0.04));
        }
        else
        {
            if (combTipo == "A" || combTipo == "a")
                valorTotal = litros * (2.9 - (2.9 * 0.04));
            else
                valorTotal = litros * (3.3 - (3.3 * 0.06));
        }
        Console.WriteLine($"O valor a ser pago é de R$ {valorTotal}");
    }
    /// <summary>
    /// verifica a igualdade entre numeros em uma lista 
    /// e retorna se são todos iguais ou quais são o maior e menor valor
    /// </summary>
    static void IgualdadeNumeros()
    {
        bool iguais = true;
        float[] numeros = new float[Utils.GetInt("Insira quantos numeros deseja verificar")];
        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = Utils.GetFloat($"Insira o valor na posição {i+1}");
            if (i > 0 && numeros[i] != numeros[i - 1])
                iguais = false;
        }

        if (iguais)
        {
            Console.WriteLine("Todos os numeros são iguais");
            return;
        }

        Console.WriteLine($"{Utils.Max(numeros)} é o maior e {Utils.Min(numeros)} é o menor numero");

        Console.Write("\nDeseja visualizar a lista de numeros organizada? digite [y] para sim ou [n] para não:\n");
        string input = Console.ReadLine();
        if (input == "n" || input == "N")
            Restart();

        Console.WriteLine("Lista organizada:\n");
        foreach (int i in Utils.Reorganize(numeros))
            Console.WriteLine(i);
    }
    /// <summary>
    /// Simula uma venda de passagens de onibus
    /// </summary>
    static void IraViajar()
    {
        bool temOnibus = Utils.GetRandom();
        float passagem = Utils.GetRandom(150, 600);
        string nome;
        float carteira;

        Console.WriteLine("Insira seu nome");
        nome = Console.ReadLine();

        carteira = Utils.GetFloat("Insira quanto tem de dinheiro");

        if (!temOnibus)
        {
            Console.WriteLine("Os onibus não estão disponiveis");
            return;
        }

        Console.WriteLine($"A passagem custa {passagem}\n");

        Console.WriteLine(nome);
        if (carteira < passagem)
        {
            Console.WriteLine("Voce não possui dinheiro o suficiente para a passagem e não podera viajar");
            return;
        }

        if (temOnibus && carteira > passagem)
            Console.WriteLine("Voce poderá viajar");
    }
    /// <summary>
    /// Conta numeros especificados pelo usuario
    /// </summary>
    static void Contador()
    {
        int min = Utils.GetInt("Insira o numero inicial");
        int max = Utils.GetInt("Insira o numero final");
        int dist = Utils.GetInt("Insira de quanto em quanto o contador deve contar");

        if (min == max)
            Restart(true, "Os numeros não podem ser iguais");

        if (min < max)
        {
            for (int i = min; i <= max; i+=1*dist)
                Console.WriteLine(i);
        }
        else
        {
            for (int i = min; i >= max; i-=1*dist)
                Console.WriteLine(i);
        }
    }
    /// <summary>
    /// traduz numeros decimais para binario e binario para decimais
    /// </summary>
    static void DecimalBinario()
    {
        string[] optionsTable = new string[]
        {
            "Decimal para Binario",
            "Binario para Decimal",
        };

        Console.WriteLine(Utils.FormatTable(optionsTable, 1, TabelaType.ENUMERATED));

        switch (Utils.GetInt("Insira sua escolha (use ',' para numeros quebrados)"))
        {
            case 0:     // Decimal para Binario
                float dec = Utils.GetFloat("Insira o numero Decimal");
                string sDec = dec.ToString();
                int befComN = 0;
                float aftComN = 0;
                bool comma = false;
                string sBefComN = "", sAftComN ="";
                string decResult = "";

                for(int i = 0; i < sDec.Length; i++)
                {
                    if (sDec[i] == ',' || sDec[i] == '.')
                    {
                        comma = true;
                        break;
                    }
                    sBefComN += Convert.ToInt32(sDec[i] - '0');
                }
                if (comma)
                {
                    for (int i = sBefComN.Length + 1; i < sDec.Length; i++)
                    {
                        sAftComN += Convert.ToInt32(sDec[i] - '0');
                    }
                }

                befComN = Convert.ToInt32(sBefComN);
                if (comma) aftComN = (float)Convert.ToDouble(sAftComN)/1000;

                while (befComN > 0)
                {
                    if (befComN % 2 == 0) decResult += "0";
                    else decResult += "1";
                    befComN /= 2;
                }
                if (comma)
                {
                    decResult += ".";
                    for (int i = 0; i < sAftComN.Length; i++)
                    {
                        if (aftComN * 2 < 1) decResult += "0";
                        else decResult += "1";
                        aftComN *= 2;
                    }
                }

                decResult = (comma) ? decResult : Utils.InvertString(decResult);

                Console.WriteLine($"{dec} em binario é: {decResult}");
                break;
            case 1:     // Binario para Decimal
                string bin = Utils.GetDouble("Insira o numero Binario").ToString();
                int befComBinN = 0;
                double aftComBinN = 0;
                string sBefComBinN = "";
                string sAftComBinN = "";
                double binResult = 0;

                for (int i = 0; i < bin.Length; i++)
                {
                    if (bin[i] == ',' || bin[i] == '.') break;
                    sBefComBinN += bin[i];
                }
                for (int i = sBefComBinN.Length+1; i < bin.Length; i++)
                    sAftComBinN += bin[i];

                sBefComBinN = Utils.InvertString(sBefComBinN);

                for (int i = 0; i < sBefComBinN.Length; i++)
                    befComBinN += (int)(Convert.ToInt32(sBefComBinN[i] - '0') * Math.Pow(2, i));
                for (int i = 0; i < sAftComBinN.Length; i++)
                    aftComBinN += ((Convert.ToInt32(sAftComBinN[i]) - '0') / Math.Pow(2, i + 1));

                binResult += befComBinN + aftComBinN;

                Console.WriteLine($"{bin} em decimal é: {binResult}");
                break;
            default:
                Restart(true, "Sua escolha estava fora dos parametros!");
                break;
        }
    }
    #endregion
}