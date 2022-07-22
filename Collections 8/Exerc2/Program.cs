using System;
using System.Collections.Generic;

namespace Exerc2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FILA DE CHAMADA");

            Queue<string> pessoas = new Queue<string>();

            pessoas.Enqueue("Binho");
            pessoas.Enqueue("Boaz");
            pessoas.Enqueue("Pamela");
            pessoas.Enqueue("Mallu");
            pessoas.Enqueue("Catarina");

            Console.WriteLine($"A primeira pessoa na fila de chamada é: {pessoas.Dequeue()}!");

            pessoas.Peek();

            Console.WriteLine($"Ainda restam na fila {pessoas.Count} pessoas!");

            foreach(string nome in pessoas)
            {
                Console.WriteLine($"Nome: {nome};");
            }
        }
    }
}
