using System;
using System.Globalization;

namespace ExercicioAula2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeCompleto, frase, ultimoNome;
            int qtdQuartos, idade;
            double precoInternet, altura;

            Console.WriteLine("Imforme seu nome completo:");
            nomeCompleto = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            qtdQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o preço da sua internet:");
            precoInternet = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe seu último nome, idade e altura (mesma linha sep. espaço.)");
            frase = Console.ReadLine();

            string[] vetor = frase.Split (" ");

            ultimoNome = vetor[0];
            idade = int.Parse(vetor[1]);
            altura = double.Parse(vetor[2]);

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(qtdQuartos);
            Console.WriteLine(precoInternet.ToString("F2",CultureInfo.InvariantCulture)); 
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2"));
            




        }
    }
}
