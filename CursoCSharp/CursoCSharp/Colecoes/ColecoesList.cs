﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class Produto
    {
        public string Nome;
        public double Preco;

        public Produto( string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object obj)
        {
            Produto outro = (Produto)obj;
            bool mesmoNome = Nome == outro.Nome;
            bool mesmoPreco = Preco == outro.Preco;
            return mesmoNome && mesmoPreco;
         }

        public override int GetHashCode()
        {
            return Nome.Length;
        }

    }
    internal class ColecoesList
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Throne", 49.9);

            var carrinho = new List<Produto>(); 
            carrinho.Add(livro);

            var combo = new List<Produto> {
            new Produto("Camisa", 29.9),
            new Produto("8 Temporada Game of Thrones", 99.9),
            new Produto("Poster", 10)
            };

            carrinho.AddRange(combo);
            Console.WriteLine(carrinho.Count);
            carrinho.RemoveAt(3);

            foreach( var item in carrinho)
            {
                Console.WriteLine(carrinho.IndexOf(item)) ;
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.LastIndexOf(livro));
        }
    }
}
