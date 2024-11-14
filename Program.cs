using System;
using System.Threading;
namespace Cronometro
{
    class Program
    {
        private static void Main()
        {
            Menu();
        }
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = segundo => 10s = 10 segundos"); //tempo = s e tipo = s ou m 
            Console.WriteLine("M = minuto => 1m = 1 minuto");
            Console.WriteLine("0 = sair");
            Console.WriteLine("Quanto tempo dejesa contar?");

            string dado = Console.ReadLine().ToLower();
            char tipo = char.Parse(dado.Substring(dado.Length - 1, 1)); //percorre toda a lista no caso a string e subtrai 1 pra peagr o ultimo caractere, no caso o S ou M
            int tempo = int.Parse(dado.Substring(0,dado.Length -1)); // no caso os segundos ou minutos     
            int multiplicador = 1;

            if(tipo == 'm')
            multiplicador = 60;

            if(tempo == 0)
            System.Environment.Exit(0);

            PreIniciar(tempo * multiplicador);


            
        }

public static void PreIniciar(int tempo){
        Console.Clear();
    Console.WriteLine("Ready...");
    Thread.Sleep(1000);
    Console.WriteLine("Set ...");
    Thread.Sleep(1000);
    Console.WriteLine("Go ...");
    Thread.Sleep(1000);
    Iniciar(tempo);

}

        static void Iniciar(int tempo)
        {

            int tempoatual = 0;

            while (tempoatual != tempo)
            {
                Console.Clear();
                tempoatual++;
                Console.WriteLine(tempoatual);
                Thread.Sleep(1000);



            }

            Console.Clear();
            Console.WriteLine("cronometro finalizado");
            Thread.Sleep(2500);
            Menu();
        }
    }
}