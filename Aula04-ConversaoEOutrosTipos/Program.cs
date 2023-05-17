using System;

class Program
{
    static void Main(string[] args)
    {
        double salario;
        salario = 3000.87;

        int salarioInt = (int)salario;
        Console.WriteLine(salarioInt);

        long valorNaoSuportadoPorTipoInt = 200000000000000;

        short tipoShort = 16000;

        //menor precisão que o double
        float tipoFloat = 15.156f;


        Console.WriteLine("Pressione Enter para encerrar...");
        Console.ReadLine();

    }
}

