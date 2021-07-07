using System;

namespace ExercicioResolvido1
{
    class Program
    {
        static void Main(string[] args)
        {
           double x =3;
           double y =4.0;
           double z = -5;
           double A, B, C;
           
           A = Math.Sqrt(x);
           B = Math.Sqrt(y);
           C = Math.Sqrt(25.0);

           Console.WriteLine("Raiz quadrada de " + x +" = " + A);
           Console.WriteLine("Raiz quadrada de " + y +" = " + B);
           Console.WriteLine("Raiz quadrada de 25 = " + C);

           A = Math.Pow(x, y);
           A = Math.Pow(x, 2.0);
           A = Math.Pow(5.0, 2.0);

           Console.WriteLine(" elevado a " + y +" = " + A);
           Console.WriteLine(" elevado ao quadrado = " + B);
           Console.WriteLine("5 elevado ao quadrado = " + C);

           A = Math.Abs(y);
           B = Math.Abs(y);
           
           Console.WriteLine("Valor absoluto de" + x +" = " + A);
           Console.WriteLine(" Valor absoluto de " + z +" = " + B);

           Console.ReadLine();

           
        }
    }
}
