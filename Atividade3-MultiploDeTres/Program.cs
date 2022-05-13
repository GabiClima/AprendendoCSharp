using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Atividade 3 - Multiplo de tres ");

        for (int i = 1; i <= 100; i++)
        {
            if (i%3 == 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}