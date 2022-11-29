using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _3_Sintaxe_e_Tipos_de_dados_em_C_.Commons.Models;

//Comentários

// Single line

/*  
    Multi
    Line
*/

///<summary>
/// Utilizado para comentar em uma classe, assim exibindo um texto explicativo ao hoverar com o mouse sobre um método/Instância.
///<summary>

Pessoa bob = new Pessoa();

bob.Idade = 19;
bob.Nome = "José";
bob.Apresentar();

Calculadora c = new Calculadora();
c.Somar(3, 4);
int sub = c.Subtrair(3, 2);
Console.WriteLine(sub);













// //Lista.

// List<string> listaString = new List<string>();

// listaString.Add("SP");
// listaString.Add("BA");
// listaString.Add("MG");
// listaString.Add("RJ");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Add("SC");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Remove("MG");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");





// Console.WriteLine("Percorrendo a lista com o FOR");
// for(int contador = 0; contador < listaString.Count; contador++)
// {
//     Console.WriteLine($"Posição Nº {contador} - {listaString[contador]}");
// }
// Console.WriteLine("Percorrendo a lista com o FOREACH");
// int contadorForEach = 0;
// foreach(string item in listaString)
// {
//     Console.WriteLine($"Posição Nº {contadorForEach} - {item}");
//     contadorForEach++;
// }




















// // Copiando arrays em outros arrays.
// int[] arrayInteiros = new int[3];

// arrayInteiros[0] = 71;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 58;

// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// foreach(int valor in arrayInteirosDobrado){
//     Console.WriteLine(valor);
// }



































// //Redimensionando um array.
// //Um array nasce e morre com o mesmo tamanho, o que ocorre é que a função resize copia os valores do array antigo, realiza um delete do array antigo e cria um novo array de maior tamanho com os valores das posições correspondentes ao array anterior;

// int[] arrayInteiros = new int[3];

// arrayInteiros[0] = 71;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 58;

// Console.WriteLine("Antes de dobrar o tamanho do array.");

// foreach(int valor in arrayInteiros){
//     Console.WriteLine(valor);
// }

// Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// Console.WriteLine("Depois de dobrar o tamanho do array.");

// foreach(int valor in arrayInteiros){
//     Console.WriteLine(valor);
// }






















// //Impressão de valores sequenciais com For Each.

// int[] arrayInteiros = new int[3];

// arrayInteiros[0] = 71;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 58;

// int contadorForEach = 0;
// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posição nº {contadorForEach} - {valor}");
//     contadorForEach++;
// }
// //valor adquire o valor de cada posição do array à cada iteração. 






















// //Impressão de valores sequênciais com for loop.

// int[] arrayInteiros = new int[3];

// arrayInteiros[0] = 71;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 58;
// //arrayInteiros[3] = 1;

// for (int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição nº {contador} - {arrayInteiros[contador]}");
// }

// // If trying to access a value outside of the array - Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.






















// int[] array = new int[4]; //Inicializa e declara tamanho do array - Quatro posições de 0 à 3.
// int[] array1 = new int[] {42, 75, 74, 61}; //Inicializa mas não declara tamanho e define variaveis.
// string[] nomes = {"Jan", "Fev"}; // Inicializa somente à partir das variáveis.

// Console.WriteLine(array);
// Console.WriteLine("\n");
// Console.WriteLine(array1);
// Console.WriteLine("\n");
// Console.WriteLine(nomes);




















// Pessoa bob = new Pessoa();

// bob.Nome = "Angelo";
// bob.Idade = 3;
// bob.Apresentar();

























// string opcao;

// while(true)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar\n");


//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1":
//         Console.WriteLine("Cadastro de Cliente\n");
//         break;

//         case "2":
//         Console.WriteLine("Buscar Cliente\n");
//         break;

//         case "3":
//         Console.WriteLine("Apagar Cliente\n");
//         break;

//         case "4":
//         Console.WriteLine("Encerrar\n");
//         Environment.Exit(0);
//         break;

//         default:
//             Console.WriteLine("Opção inválida");
//             break;
//     }
// }
























// int soma = 0, numero = 0;

// do
// {
//     Console.WriteLine("Por favor digite um número - (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());
//     if (numero == 0){
//         Console.WriteLine($"Sua soma final foi {soma}");
//         break;
//     }
//     soma += numero;

//     Console.WriteLine($"Sua soma no momento é {soma}");

// } while(numero != 0);

























// int numero = 1;

// Console.WriteLine($"Tabuada do {numero}");


// while(numero <= 10)
// {
//     for(int contador = 0; contador <= 10; contador++)
//     {
//          Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//     }
//     numero++;
//     if(numero <= 10)
//     {
//         Console.WriteLine($"\nTabuada do {numero}");
//     }
// }


























// Calculadora calc = new Calculadora();


// // int numero = 10;

// // Console.WriteLine(numero);

// // Console.WriteLine("Incrementando o 10");

// // numero++;

// // Console.WriteLine(numero);

// // Console.WriteLine("Decrementando o 11");

// // numero--;

// // Console.WriteLine(numero);

// calc.RaizQuadrada(2);

















// calc.Potencia(3,3);
// calc.Seno(45);
// calc.Cosseno(45);
// calc.Tangente(45);





















// calc.Somar(12,13);
// calc.Subtrair(10,50);
// calc.Multiplicar(2,132);
// calc.Dividir(3,2);
