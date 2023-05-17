using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Aula 10 - Calcula valor da poupança");

        double investimento = 1000.0;
        double rendimento = 0.005;
        int mes = 1;
        //rendimento de 0,005 por mês
        

        while(mes <= 12)
        {
            investimento = investimento + investimento * rendimento;
            Console.WriteLine("No mês " + mes + " vocé tem R$" + investimento);
            mes++;
        }


        Console.WriteLine("Pressione Enter para encerrar...");
        Console.ReadLine();

    }
}

