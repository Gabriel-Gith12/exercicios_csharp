using System;

namespace Checklist
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;

            Console.WriteLine("digite uma string");
            string s = Console.ReadLine();

            string a,b,c;

            Console.WriteLine("digite a primeira palavra");
            string s = Console.ReadLine();

            Console.WriteLine("digite a segunda palavra");
            string s = Console.ReadLine();

            Console.WriteLine("digite a terceira palavra");
            string s = Console.ReadLine();

            string[] frase = Console.ReadLine().Split(" ");
            string x,y,z;
            x = frase[0];
            y = frase[1];
            z = frase[2];

            Console.WriteLine("voce digitou");
            Console.WriteLine(s);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

        }
    }
}
