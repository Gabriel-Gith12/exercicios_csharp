using System;

namespace ExercicioResolvido3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa para ler o nome (apenas uma palavra) e 
            // idade de duas pessoas. Ao final mostrar uma mensagem com os nomes e a 
            // idade média entre essas pessoas, com uma casa decimal, conforme exemplo.
            // Exemplo: Entrada: Nairo 53
            //                   Rafael 32
            // Saída
            // A idade média de Nairo e Rafael é de x  anos
            
            string frase, nome1, nome2;
            string[] vetor;
            int idade1, idade2;
            double media;

            frase = Console.ReadLine();
            vetor = frase.Split(' ');
            nome1 = vetor[0];
            idade1 = int.Parse(vetor[1]);

            frase = Console.ReadLine();
            vetor = frase.Split(' ');
            nome2 = vetor[0];
            idade2 = int.Parse(vetor[1]);

            media = (double) (idade1 + idade2) / 2.0;
            Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de " + media.ToString("F1")+" anos.");

        }
    }
}
