using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 7 - Condicionais");

        int idade = 18;
        int quantidadeAcompanhantesMaiorDeIdade = 1;

        if (idade < 18 && quantidadeAcompanhantesMaiorDeIdade == 0)
        {
            Console.WriteLine("Menor de idade");
            return;
        }
        else if (idade < 18 && quantidadeAcompanhantesMaiorDeIdade > 0)
        {
            Console.WriteLine("Pode entrar acompanhado");
            return;
        }

        Console.WriteLine("Maior de idade");

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}