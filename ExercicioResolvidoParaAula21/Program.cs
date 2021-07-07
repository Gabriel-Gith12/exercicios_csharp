using System;
using System.Diagnostics;

namespace ExercicioResolvidoParaAula21
{
    class Program
    {
        static void Main(string[] args)
        {
           /// Intancia do precesso de inicializacao de programa
           ProcessStartInfo pro = new ProcessStartInfo();
           /// Definindo o Nome do Programa
           pro.FileName = "cmd.exe";
           /// Inicia um nome Processo
           Process processo = new Process();
           processo.StartInfo = pro;
           /// Chamada o metdo star para iniciar o Precesso
           processo.Start();

           for(int x = 1;x <= 10; x++)
           {
           /// Executamos o bloco de Notas
           Process.Start("notepad.exe");
           }
        }
    }
}
