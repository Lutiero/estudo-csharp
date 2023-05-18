using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Aula 12 - Invetimento a longo prazo");

        double fatorRendimento = 1.005;
        double investimento = 1000;

        for (int ano = 1; ano <= 5; ano++)
        {

            for (int mes = 1; mes <= 12; mes++)
            {
                investimento *= fatorRendimento;                
            }

            fatorRendimento += 0.001;
            Console.WriteLine(investimento);
        }


        Console.WriteLine("Pressione Enter para encerrar...");
        Console.ReadLine();

    }
}

