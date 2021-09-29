using System;
using System.Collections.Generic;

namespace listExample {
    class Program {
        static void Main(string[] args) {
            List<string> list = new List<string>();

            list.Add("Luiz"); // add = sempre adiciona o elemento no final da lista
            list.Add("Lucas");
            list.Add("Grazi");
            list.Add("Maia");
            list.Insert(4, "Lassy"); // insert = adiciona o elemento na posição do indice

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            // tamanho da lista
            Console.WriteLine("List count: " + list.Count);
            Console.WriteLine("-------------------");
            //nomes com 5 letras
            List<string> list2 = list.FindAll(x => x.Length == 5);
            foreach (string obj in list2) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List2 count: " + list2.Count);
        }
    }
}
