using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 13 - Encadeando For");

        for(int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
        {
            Console.WriteLine();
            for(int contadorColunas = 0; contadorColunas < 10; contadorColunas++)
            {
                Console.Write('*');
                if(contadorColunas >= contadorLinhas)
                {
                    break;
                }
            }
        }

        // Outra forma de fazer a mesma coisa

        for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
        {
            Console.WriteLine();
            for (int contadorColunas = 0; contadorColunas <= contadorLinhas; contadorColunas++)
            {
                Console.Write('*');
            }
        }

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}