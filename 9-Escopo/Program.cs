using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 09 - Escopo ");

        int idadeRafael = 17;
        int quantidadeDePessoas = 2;

        bool acompanhado = quantidadeDePessoas > 1;//essa afirmativa é verdadeira, ou seja, true

        string textoAdiocional;

        if (acompanhado == true)
        {
            textoAdiocional = "Rafael está acompanhado!";
        }
        else
        {
            textoAdiocional = "Rafael não está acompanhado!";
        }
        if (idadeRafael >= 18 || acompanhado)
        {
            Console.WriteLine(textoAdiocional);
            Console.WriteLine("Pode entrar");
        }
        else
        {
            Console.WriteLine(textoAdiocional);
            Console.WriteLine("Não pode entrar");
        }

        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}
