using System;
namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, dias, resto, horas, minutos, segundos, restoo;
            Console.WriteLine("Conversor de tempo");
            Console.WriteLine("Escreva um numero que será convertido em dias, horas, minutos e segundos ");
            N = int.Parse(Console.ReadLine()!);
            dias = N / 86400;
            restoo = N % 86400;
            horas = restoo / 3600;
            resto = N % 3600;
            minutos = resto / 60;
            segundos = resto % 60;
            Console.WriteLine("O número " + N + " representa " + dias + " dias" + ":" + horas + " horas" + ":" + minutos + " minutos" + ":" + segundos + " segundos ");
            Console.ReadLine();
        }
    }
}