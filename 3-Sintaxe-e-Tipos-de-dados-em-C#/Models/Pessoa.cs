using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3._Sintaxe_e_Tipos_de_dados_em_C_.Models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        
        public void Apresentar()
        {
            Console.WriteLine($"Olá\nMeu nome é {Nome} e tenho {Idade} Anos.");
        }
    }
}