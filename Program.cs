using System;
using System.Collections.Generic;

namespace Aula27_28_29_30
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Produto p1 = new Produto();
            p1.Codigo = 1;
            p1.Nome = "Ela";
            p1.Preco = 99f;

            p1.Cadastrar(p1);

            List<Produto> lista = p1.Ler();
          
           foreach(Produto item in lista){
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                System.Console.WriteLine($"R$:{item.Preco} - {item.Nome}");
            }

            //Buscar por Nome através da expressão lambda
            Produto R6 = lista.Find(x => x.Nome == "Ela");

            System.Console.WriteLine(R6.Nome);

        }
        
        
    }
}

