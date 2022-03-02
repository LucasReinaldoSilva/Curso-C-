using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestante = 5;
            int tentativas = 0;

            while(tentativasRestante > 0 && !numeroEncontrado)
            {
                Console.WriteLine("Insira o seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestante--;

                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Numero encontrado em {0} tentativas", tentativas);
                    Console.BackgroundColor = corAnterior;
                } else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("Menor... Tente Novamente");
                    Console.WriteLine("Tentativas Restantes: {0}", tentativasRestante);
                } else
                {
                    Console.WriteLine("Maior... Tente Novamente");
                    Console.WriteLine("Temtativas Restantes: {0}", tentativasRestante);
                }
            }
        }
    }
}
