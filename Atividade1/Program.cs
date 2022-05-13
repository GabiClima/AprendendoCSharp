using System;

class Programa
{
    static void Main(string[] args)
    {

        double n1, n2, n3, n4, resultado, media;

        resultado = n1 = n2 = n3 = n4 = 0;

        Console.Write("Digite a nota 1: ");
        n1 = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota 2: ");
        n2 = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota 3: ");
        n3 = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota 4: ");
        n4 = double.Parse(Console.ReadLine());

        resultado = n1 + n2 + n3 + n4;
        Console.WriteLine("A soma das notas é " + resultado,2f);

        media = resultado / 4;
        Console.WriteLine("A média das notas é " + media,2f);

        if (media >= 6)
        {
            Console.WriteLine("APROVADO!");
        }else if(media == 5)
        {
            Console.WriteLine("RECUPERAÇÃO!");
        }
        else
        {
            Console.WriteLine("REPROVADO!");
        }




        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}
