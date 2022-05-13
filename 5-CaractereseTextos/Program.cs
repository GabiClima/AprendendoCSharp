using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pojeto 05 - Caracteres e Textos");

        //ESCREVENDO CARACTERES UTILIZANDO CHAR, QUE SE UTILIZA '':

        char letra = 'a';
        //Console.WriteLine(letra);

        //ascii: codificação de numeros decimais em letras
        //meu nome em ascii em linhas separadas:
        letra = (char)71;
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)66;
        Console.WriteLine(letra);

        letra = (char)82;
        Console.WriteLine(letra);

        letra = (char)73;
        Console.WriteLine(letra);

        letra = (char)69;
        Console.WriteLine(letra);

        letra = (char)76;
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);




        //meu nome em ascii na mesma linha:
        letra = (char)71;
        Console.Write(letra);

        letra = (char)65;
        Console.Write(letra);

        letra = (char)66;
        Console.Write(letra);

        letra = (char)82;
        Console.Write(letra);

        letra = (char)73;
        Console.Write(letra);

        letra = (char)69;
        Console.Write(letra);

        letra = (char)76;
        Console.Write(letra);

        letra = (char)65;
        Console.WriteLine(letra);



        //ESCREVENDO TEXTO UTILIZANDO STRING, ONDE SE USA "":

        string primeiraFrase = "SENAI - Cursos de Tecnologia ";
        //quando eu vou concatenar com uma string eu não preciso colocar o 2022(exemplo) entre aspas, pq ele já reconhece que é a continuação de uma string:
        Console.WriteLine(primeiraFrase + 2022);

        //string podemos crias ela vazia sem espaço:
        string vazia = "";
        Console.WriteLine(vazia);

        //não pode criar um char sem espaço, já que espaço é um caractere:
        letra = ' ';

        //@ serve para concatenaer automaticamente:
        string cursos = @"Cursos disponiveis: 
 -C
 -C++ 
 -HTML
 -C#";  
        Console.WriteLine(cursos);


        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}
