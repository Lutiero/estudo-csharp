using System;

class Program
{
    static void Main(string[] args)
    {
        double salario = 3000.16;
        Console.WriteLine(salario);
        double desconto = salario * 0.20;
        Console.WriteLine(desconto);
        salario = salario - desconto;
        Console.WriteLine(salario);

    }
}

