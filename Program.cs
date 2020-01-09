using System;

namespace LetrasCoach
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string letras =" ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int total = 0;

            string decisao = "S";
            string sequencia = "";
            
            while(decisao=="S")
            {
                    Console.WriteLine("Escreva a palavra:");
                    var palavra = Console.ReadLine().ToUpper();
                    total=0;
                    sequencia = "";
                    
                    foreach (char item in palavra)
                    {
                        total+= letras.IndexOf(item);
                        sequencia+= $" {item} +";
                    }
                    Console.Write($"{sequencia.Substring(0,sequencia.Length-1)}= {total} \n");
            }

        }
    }
}
