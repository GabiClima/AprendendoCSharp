using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 10 - Calcula Poupança ");

        double investimento = 1000;
        //rendimento de 0,5%(0,5/100 = 0,005) ao mes

        //mes 1
        //investimento = investimento + investimento * 0.005;
        //Console.WriteLine(investimento);
        ////mes 2
        //investimento = investimento + investimento * 0.005;
        //Console.WriteLine(investimento);
        ////mes 3
        //investimento = investimento + investimento * 0.005;
        //Console.WriteLine(investimento);

        int mes = 1;

        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("Mes " + mes + " = " + investimento);
            mes++;
            //mes += 3 ---> incremento com valor maior que 1 se usa +=
        }

        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}