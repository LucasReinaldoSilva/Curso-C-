using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                //Fundamentos 
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar },
                {"Váriaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar },
                {"Inferência - Fundamentos", Inferencia.Executar },
                {"Interpolação - Fundamentos", Interpolacao.Executar },
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos", lendoDados.Executar },
                {"Formatando Número - Fundamentos", FormatandoNumero.Exectuar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritiméticos  - Fundamentos", OperadoresAritimeticos.Executar },
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar },
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar },
                {"Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar },
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar },
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar },

                //Estrutura de Controle
                {"Estrutura If - Estrutura de Controle", EstruturaIf.Executar },
                {"Estrutura If/Else - Estrutura de Controle", EstruturaIfElse.Executar },
                {"Estrutura If/Else/If - Estrutura de Controle", EstruturaIfElseIf.Executar },
                {"Estrutura Switch - Estrutura de Controle", EstruturaSwitch.Executar },
                {"Estrutura While - Estrutura de Controle", EstruturaWhile.Executar },
            }); ;

            central.SelecionarEExecutar();
        }
    }
}