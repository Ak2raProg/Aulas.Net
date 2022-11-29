using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3_Sintaxe_e_Tipos_de_dados_em_C_.Commons.Models
{/// <summary>
/// Instância da classe pessoa.
/// </summary>
     public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        /// <summary>
        /// Faz a pessoa se apresentar
        /// </summary>
        public void Apresentar()
        {
            Console.WriteLine($"Olá\nMeu nome é {Nome} e tenho {Idade} Anos.");
        }
    }
}