using System;

class Program
{
    static bool VerificarAtributo(string atributo, int valorMinimo, int valorMaximo, int valorAtributo)
    {
        if(valorAtributo > valorMaximo || valorAtributo < valorMinimo)
        {
            Console.WriteLine("O valor do atributo está fora do intervalo especificado");
            return false;
        }
        else
        {
            Console.WriteLine("O valor do atributo está dentro do intervalo especificado");
            return true;
        }
    }

    static void Main(string[] args)
    {
        string atributo = Console.ReadLine();

        int valorMinimo = int.Parse(Console.ReadLine());

        int valorMaximo = int.Parse(Console.ReadLine());

        int valorAtributo = int.Parse(Console.ReadLine());

        VerificarAtributo(atributo, valorMinimo, valorMaximo, valorAtributo);
    }
}