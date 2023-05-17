using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Aula 11 - Calcula valor da poupança com laço for");

        double investimento = 1000.0;
        double rendimento = 1.005;

        for (int mes = 1; mes <= 12; mes++)
        {
            investimento *= rendimento;
            Console.WriteLine("O rendimento no mês " + mes + " foi de R$" + investimento);
        }


        Console.WriteLine("Pressione Enter para encerrar...");
        Console.ReadLine();

    }
}

