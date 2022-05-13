using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 11 - Investimento a longo prazo ");

        double fatorDeRendimento = 1.005;
        double investimento = 1000;

        for (int anos = 1; anos <= 5; anos++)
        {
            for (int mes = 1; mes <= 12; mes++)
            {
                investimento *= fatorDeRendimento;
                Console.WriteLine("No mes " + mes + " o investimento é " + investimento);
            }
            fatorDeRendimento += 0.001;
            Console.WriteLine();
         
        }
        Console.WriteLine("Depois de 5 anos voce terá " + investimento);

        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}