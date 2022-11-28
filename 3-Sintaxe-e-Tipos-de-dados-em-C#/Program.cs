 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 using _3_Sintaxe_e_Tipos_de_dados_em_C_.Models;

string opcao;

while(true)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar\n");


    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
        Console.WriteLine("Cadastro de Cliente\n");
        break;

        case "2":
        Console.WriteLine("Buscar Cliente\n");
        break;

        case "3":
        Console.WriteLine("Apagar Cliente\n");
        break;

        case "4":
        Console.WriteLine("Encerrar\n");
        Environment.Exit(0);
        break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}
























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
