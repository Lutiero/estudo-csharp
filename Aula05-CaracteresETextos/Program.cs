using System;

class Program
{
    static void Main(string[] args)
    {
        char letra = 'a';
        Console.WriteLine("char: " + letra);

        // Tabela ASCII
        letra = (char)(65 + 1);
        Console.WriteLine("char(" + (int)letra + "): " + letra);

        // Strings
        string frase = "Um novo dia, uma nova regra, uma nova exceção.";        
        Console.WriteLine("string: " + frase);

        string cursos = @"Cursos disponíveis: 
    - C# 
    - Javascript 
    - GO";
        Console.WriteLine(cursos);

        Console.WriteLine("");
        Console.WriteLine("Pressione Enter para encerrar...");
        Console.ReadLine();

    }
}

