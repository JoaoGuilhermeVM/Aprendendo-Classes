using System;

namespace AprendendoClasses
{
    class Program
    {
        static void Main()
        {
            //Desafio de programação: Implemente um método da classe Math que retorne o maior de dois números.

            int firstValue = 500;
            int secondValue = 600;
            int largerValue = Math.Max(firstValue, secondValue);

            //Sua solução final para este desafio deve usar este código e deve usar a Console.WriteLine(largerValue);instrução para gerar a saída.
            Console.WriteLine(largerValue);
        }
    }
}
//No uso do InteliSense, a solução para um erro do codigo foi criar uma classe e colocar meu programa dentro dela, e depois criar um metodo para o programa, e depois chamar o metodo no Main, e depois usar o Console.WriteLine para mostrar o resultado.
//Solução dado pela Microsoft Learn:
//int firstValue = 500;
//int secondValue = 600;
//int largerValue;
//largerValue = Math.Max(firstValue, secondValue);
//Console.WriteLine(largerValue);