using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class MetodosEstaticos
    {
        class CalculadoraEstatica
        {
           // Método de Instância
            public int Somar(int a, int b)
            {
                return a + b;
            }
            
            // Método Estático
            public static int Multiplicar(int a, int b)
            {
                return a * b;
            }
        }
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("Resultado: {0}",resultado);

            
            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(2, 2));

        }
    }
}
