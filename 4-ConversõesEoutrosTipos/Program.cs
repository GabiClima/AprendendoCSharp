using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 04 - Conversões e outros tipos");

        double salario;
        salario = 3000.15;
        Console.WriteLine(salario);

        int salarioInteiro;
        salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);

        //long é um tipo de variavel de 64 bits
        long x;
        x = 20000000000000;
        Console.WriteLine(x);


        short y;
        y = 150;
        Console.WriteLine(y);

        float altura;
        altura = 1.72f;

        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
            
     }
}
