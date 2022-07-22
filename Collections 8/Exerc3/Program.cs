using System;
using System.Collections.Generic;

namespace Exerc3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LIVROS ESCOLARES");

            Stack<string> livro = new Stack<string>();

            livro.Push("Matemática");
            livro.Push("Química");
            livro.Push("Biologia");

            Console.WriteLine($"O primeiro livro da pilha é o de {livro.Peek()}!");

            livro.Pop();

            Console.WriteLine($"Ainda restam {livro.Count} na pilha.");

            foreach (var item in livro)
            {
                Console.WriteLine($"Temos o livro de {item};");
            }
        }
    }
}
