using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 07 - Condicionais ");

        int idadeRafael = 17;
        int quantidadeDePessoas = 2;

        if (idadeRafael >= 18)
        {
            Console.WriteLine("Pode ENTRAR!");
        }
        else
        {
            if (quantidadeDePessoas > 1)
            {
                Console.WriteLine("Ele está acompanhado. Pode entrar ");
            }
            else
            {
                Console.WriteLine("Não pode ENTRAR!");
            }
        }

        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}
