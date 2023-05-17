using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 7 - Condicionais");

        int idade = 16;
        int quantidadeAcompanhantesMaiorDeIdade = 2;

        bool acompanhado = quantidadeAcompanhantesMaiorDeIdade > 1;

        if (idade >= 18 || acompanhado)
        {
            Console.WriteLine("Pode entrar");
        }
        else
        {
            Console.WriteLine("Nao pode entrar");
        }


        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}