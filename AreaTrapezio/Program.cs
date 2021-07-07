using System;

namespace AreaTrapezio
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaracao das variaveis
            double b, B, h, area;

            // inicializacao
            b = 5.0;
            B = 6.0;
            h = 12.0;

            // processamento
            area = (b + B) / 2.0 * h;
            Console.WriteLine(area);
        }
    }
}
