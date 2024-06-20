using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trab_Fliperama.Models;
using Trab_Fliperama.Controllers;
using Trab_Fliperama.Repository;
using Trab_Fliperama.Views;


namespace Trab_Fliperama.Games
{
    public class GuessANumber
    {
        public GuessANumber()
        {
            this.Init();
        }

        public void Init()
        {
            int value = Random.Shared.Next(1, 101);

            while (true)
            {
                Console.Write("Adivinhe um valor: ");
                bool valid = int.TryParse((Console.ReadLine()), out int input);
                if (!valid) 
                {
                    Console.WriteLine("Invalid.");
                } 
                else if (input == value) 
                {
                    break;
                } 
                else 
                {
                    Console.WriteLine($"Incorreto. Valor muito {(input < value ? "é muito baixo!" : "é muito alto!")}.");
                }
            }

            Console.WriteLine("Você acertou!");
            Console.Write("Pressione qualquer tecla para sair.");
            Console.ReadKey(true);
        }
    }
}