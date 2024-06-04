using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número inteiro:");
        
        int numero = Convert.ToInt32(Console.ReadLine());
        
        if (numero > 0)
        {
            Console.WriteLine("O número inserido é positivo.");
        }
        else if (numero < 0)
        {
            Console.WriteLine("O número inserido é negativo.");
        }
        else
        {
            Console.WriteLine("O número inserido é zero.");
        }
    }
}
