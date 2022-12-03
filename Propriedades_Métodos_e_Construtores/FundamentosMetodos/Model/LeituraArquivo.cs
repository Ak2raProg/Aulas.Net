using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundamentosMetodos.Model
{
    public class LeituraArquivo
    {

        //Este unico método retorna 3 tipos de testes/informações através de uma Tupla
        public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivo(string caminho)
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);

                return (true, linhas, linhas.Count());
            }
            catch(Exception)
            {
                return (false, new string[0], 0);
            }
        }
    }
}