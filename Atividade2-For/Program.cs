using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Atividade 2 - For ");

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

        for(int mes = 1; mes <= 12; mes++)
        {
            investimento = investimento + investimento * 0.005;
            //investimento *= 1.005; ----> outro modo de fazer oq esta acima.
            Console.WriteLine("Mes " + mes + " = " + investimento);
       
        }

        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}