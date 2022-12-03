using FundamentosMetodos.Model;
using System.Globalization;//Alterar cultura (Formata de acordo com localização no globo -- i.e moeda do país, linguagem))
using Newtonsoft.Json;

//Valores nulos

bool? desejaReceberEmail = null;

if(desejaReceberEmail.HasValue && desejaReceberEmail.Value)
{
    Console.WriteLine("O usuário optou por receber e-mail");
}
else
{
    Console.WriteLine("O usuário não respondeu ou optou por não receber e-mail");
}




















// //Deserializando um arquivo Json

// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach(Venda venda in listaVenda)
// {
//     Console.WriteLine($"Id: {venda.Id}");
//     Console.WriteLine($"Produto: {venda.Produto}");
//     Console.WriteLine($"Preço: {venda.Preco}");
//     Console.WriteLine($"Data da venda: {venda.DataVenda.ToString("dd/MM/yyyy  hh:mm")}");
// }





















// //NuGet - Gerenciador de pacotes do .Net

// //Realizado download do pacote Newtonsoft.JSON
// //cmd: dotnet add package Newtonsoft.Json --version 13.0.2

// //Serialização de dados em JSON - JavaScript Notation Object
// // - Definição de um objeto em um arquivo de texto.
// /*↓ Padrão JSON ↓
// {
//     "id": 1,
//     "Produto": "P1",
//     "Preco": 10.50
// }
// */
// //Serialização de um objeto exemplo.

// DateTime atual = DateTime.Now; //Displayed no arquivo Json em formato ISO 8601

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de escritório", 25.00M, atual);
// Venda v2 = new Venda(1, "Licença de Software", 110.00M, atual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// Console.WriteLine(serializado);

// File.WriteAllText("Arquivos/vendas.json", serializado);


//Deserializando um objeto

























// int numero = 15;
// bool ehPar = false;

// //Utilizando IF ternário
// ehPar = numero % 2 == 0;
// Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));
// //------------------------------------------bool-var--true----false-------


//Método básico de escrita
// if (numero % 2 == 0) 
// {
//     Console.WriteLine($"O número {numero} é par");
// }
// else
// {
//     Console.WriteLine($"O número {numero} é ímpar");
// }





















// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if(sucesso)
// {
//     Console.WriteLine("Qunatidade de linhas do arquivo: " + quantidadeLinhas);
//     foreach(string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possível ler o arquivo");
// }

//Descarte - Conceito: Descartar valores retornados não utilizados de modo à não poluir o código e não criar variáveis não utilizadas.
//var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");
//----------------------------↑↑------- O underline representa o valor descartado e não atribuído.



//Desconstrutor - Escrito na classe pessoa.
//Torna o código muito mais conciso quando necessário "resgatar" valores de um objeto e atribuí-los à variáveis locais.
//Multiplos métodos Deconstruct podem ser criados desde que cada um retorne um número diferente de parâmetros.

// Pessoa p1 = new Pessoa("Ricardo", "Akira");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");





























// //Tuplas - Permitem agrupamento de diferentes elementos.

// //3 Maneiras de criar uma tupla.
// (int, string, string, decimal) tupla = (1, "Ricardo", "Akira", 1.85M);
// ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Ricardo", "Akira", 1.85M);
// var outroExemploTuplaCreate = Tuple.Create(1, "Ricardo", "Akira", 1.80M);


// Console.WriteLine($"Id: {tupla.Item1}");
// Console.WriteLine($"Nome: {outroExemploTupla.Item2}");
// Console.WriteLine($"Sobrenome: {outroExemploTuplaCreate.Item3}");
// Console.WriteLine($"Altura: {tupla.Item4}");



































// //Dictionary - Sistema chave valor com chaves únicas

// Dictionary<string, string> estados = new Dictionary<string, string>();
// estados.Add("PR", "Paraná");
// estados.Add("SC", "Santa Catarina");
// estados.Add("TO", "Tocantins");
// estados.Add("SP", "São Paulo");

// //KeyValuePair<string,string> pode ser substituido por "var" para que seja alocado automaticamente o tipo de variável.
// foreach(KeyValuePair<string,string> item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// Console.WriteLine("----------");

// Console.WriteLine($"Removendo par chave-valor \"SC\"");
// estados.Remove("SC");

// foreach(KeyValuePair<string,string> item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// Console.WriteLine("----------");

// Console.WriteLine($"Alterando par chave-valor \"PR\"");
// estados["PR"] = "Paraná - Valor alterado";

// foreach(KeyValuePair<string,string> item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// Console.WriteLine("----------");


// string chave = "BA";
// Console.WriteLine($"Verificando o elemento: {chave}");
// if(estados.ContainsKey(chave))
// {
//     Console.WriteLine("Chave encontrada.");
//     Console.WriteLine($"Valor: {estados[chave]}");
// }
// else
// {
//     Console.WriteLine($"Chave não encontrada, é seguro adicionar uma chave com o valor {chave}.");
// }

// //Stack - Coleções (LIFO - Last In First Out)
// /*
//     1°  2°  3°  4°  5°  6°  7°  8º
//                 ↓↓  ↑↑
//             ↓↓  61  61  ↑↑
//         ↓↓  74  74  74  74  ↑↑
//     ↓↓  75  75  75  75  75  75  ↑↑
//     42  42  42  42  42  42  42  42
// ---    
// */

// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// Console.WriteLine("Adicionando um novo elemento");
// pilha.Push(12);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }










// //Queue - Fila (FIFO - First In First Out)
// //1→ 1  2→ 2,1  5→ 5,2,1 Enqueue
// //1← 5,2  2← 5 Dequeue

// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }


























// ExemploExcecao exemplo = new ExemploExcecao();

// exemplo.Metodo1();



































// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Pasta não encontrada. {ex.Message}");
// }
// catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally //Ocorre ao final do bloco try, independente de haver erro ou não.
// {
//     Console.WriteLine("Chegou até aqui;")
// }


































// DateTime data = DateTime.Now;

// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

// Console.WriteLine(data.ToShortDateString());

// Console.WriteLine(data.ToShortTimeString());

// DateTime aniversario = DateTime.Parse("19/12/1995 13:00");//Caso a string não possa ser convertida o programa será encerrado.
// Console.WriteLine(aniversario);

// string dataString = "2000-13-17 18:00";
// //TryParseExact faz a validação do dado antes de convertê-lo, caso a data esteja inválida será exibido 01/01/0001 00:00 sem encerrar o programa.
// bool sucesso = DateTime.TryParseExact(dataString,
//                        "yyyy-MM-dd HH:mm",
//                         CultureInfo.InvariantCulture,
//                         DateTimeStyles.None,
//                          out DateTime dataParse);

// if(sucesso)
// {
//     Console.WriteLine("Data válida");
// }
// else
// {
//     Console.WriteLine("Por favor digite uma data válida");
// }

// Console.WriteLine(dataParse);






























// //Altera "localização" para os EUA, assim também mudando a formatação da moeda.
// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 1282.40M;
// //Adicionar :C formata o valor como "Currency", assim atribuindo cifrões,virgulas e pontos conforme a moeda configurada.
// // Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));//Printa o valor em dólar $1,282.40
// // Console.WriteLine(valorMonetario.ToString("C2"));//Altera o numero de casas decimais
// // Console.WriteLine(valorMonetario.ToString("N2"));//Exibe o número com duas casas decimais e fora da formatação currency.


// double porcentagem = .3421;
// Console.WriteLine(porcentagem.ToString("p"));//Formata como porcentagem.

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));//Altera o numero de casas decimais





















//A string recebe prioridade e o int é convertido em string.
// string numero1 = "10";
// int numero2 = 20;

// string resultado = numero1 + numero2;
// Console.WriteLine(resultado);
























// //Criado utilizando um construtor sem parâmetros.
// Pessoa p1 = new Pessoa(); 
// p1.Nome = "Eduardo";
// p1.Sobrenome = "Buta";

// //Criado utilizando um construtor que aceita nome e sobrenome.
// Pessoa p2 = new Pessoa("Eduardo","Neves Queiroz");
// //O nome do parâmetro pode ser adicionado para clarificar o código.
// //Pessoa p2 = new Pessoa(nome: "Eduardo",sobrenome:"Neves Queiroz");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();























// Console.WriteLine("Por favor informe seu nome:");
// string nome = Console.ReadLine();
// Console.WriteLine("Por favor informe seu sobrenome:");
// string sobrenome = Console.ReadLine();
// Console.WriteLine("Por favor informe sua idade:");
// int idade = Convert.ToInt32(Console.ReadLine());

// Pessoa generico = new Pessoa();

// generico.Nome = nome;
// generico.Idade = idade;
// generico.Sobrenome = sobrenome;


// generico.Apresentar();
