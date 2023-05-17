using System;

class Program
{
    static void Main(string[] args)
    {
        double salario = 3300.0;
        double ir = 0.075;
        int deducao = 142;
        double valorPagoDeImposto = 0.0;

        if (salario >= 1900.0 && salario <= 2800.0)
        {
            ir = 0.075;
            deducao = 142;
            valorPagoDeImposto = (salario * ir);
        }
        else if (salario >= 2800.01 && salario <= 3751.0)
        {
            ir = 0.15;
            deducao = 350;
            valorPagoDeImposto = (salario * ir);
        }
        else
        {
            ir = 0.225;
            deducao = 636;
            valorPagoDeImposto = (salario * ir);
        }

        Console.WriteLine("Dedução: " + deducao);
        Console.WriteLine("IR: " + valorPagoDeImposto);
    }
}