using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Back_End_ER05.Classes
{
    public static class Utils
    {
        public static void BarraCarregamento(string texto)
        {
            Console.Write($"{texto}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Yellow;
            for (var contador = 0; contador < 5; contador++)
            {
                Console.Write($"-");
                Thread.Sleep(500);
            }
            Console.ResetColor();
        }










    }
}