using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 7 - Condicionais");

        int idade = 16;
        int quantidadeAcompanhantesMaiorDeIdade = 1;

        bool acompanhado = quantidadeAcompanhantesMaiorDeIdade > 1;

        string textoAdicional;

        if (acompanhado)
        {
            textoAdicional = ". Está acompanhado";
        }
        else
        {
            textoAdicional = ". Não está acompanhado";
        }

        if (idade >= 18 || acompanhado)
        {
            Console.WriteLine("Pode entrar" + textoAdicional);
        }
        else
        {
            Console.WriteLine("Nao pode entrar" + textoAdicional);
        }


        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}