﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaIfElse
    {
        public static void Executar()
        {
            double nota = 7.0;

            if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado !");
                Console.WriteLine("Não fez mais do que a obrigação...");
            } else
            {
                Console.WriteLine("Recuperação");
                Console.WriteLine("Que Feio!!");
            }
        }
    }
}
