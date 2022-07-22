using System;
using System.Collections.Generic;

namespace Exerc1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ANIMAIS DO BOAZ");
            List<string> lista = new List<string>();

            lista.Add("gatos");
            lista.Add("porquinhos da Índia");
            lista.Add("periquitos");
            lista.Add("papagaios");

            lista.Insert(1, "hamsters");

            lista.Remove("papagaios");

            lista.RemoveAt(1);

            foreach (string item in lista)
            {
                Console.WriteLine($"Boaz tem {item}!");
            }



        }
    }
}
