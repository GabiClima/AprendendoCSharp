using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 08 - Condicionais 2 ");

        int idadeRafael = 17;
        int quantidadeDePessoas = 2;

        bool acompanhado = quantidadeDePessoas > 1;

        bool grupo = false;

        if (idadeRafael >= 18 || acompanhado)
        {
            Console.WriteLine("Pode ENTRAR!");
        }
        else
        {
            Console.WriteLine("Não pode ENTRAR!");
        }


        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}
