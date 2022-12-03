using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundamentosMetodos.Model
{
    public class Pessoa
    {

        //Construtores - Podem ser criados infinitos construtores com diferentes parâmetros instanciados.

        public Pessoa()
        {
            //Construtor que não recebe nenhum parâmetro.
        }
        public Pessoa(string nome, string sobrenome)
        {
            //Construtor caso os parâmetros sejam passados.
            Nome = nome;
            Sobrenome = sobrenome;
        }
        //Método desconstrutor
        public void Deconstruct(out string nome, out string sobrenome)
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }

        private string _nome;
        private int _idade;

        private string _sobrenome;

        public string Nome 
        {
            // get
            // {

            //     return _nome.ToUpper();

            // }

            get => _nome.ToUpper();

            set
            {
                if(value == "")
                {
                    //Encerra o código e reproduz a mensagem junto às mensagens de erro
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            } 
        }

        public string Sobrenome { get => _sobrenome.ToUpper(); set { _sobrenome = value; } }
        public string NomeCompleto => $"{_nome} {_sobrenome}".ToUpper();
        public int Idade
        {
            get => _idade;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("O valor idade é inválido, por favor digite um valor maior que zero");
                }

                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, me chamo {NomeCompleto} e tenho {_idade} anos.");
        }
    }
}