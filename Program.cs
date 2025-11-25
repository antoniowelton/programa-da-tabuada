namespace programa_da_tabuada;

class Program
{
    static void Main(string[] args)
    {

        
        Console.WriteLine("\nDigite um número pra ver sua tabuada: \n");
        int numero = Convert.ToInt32(Console.ReadLine());
        Console.Write("\n");

        for (int i = 0; i <= 10; i++)
        {
            Console.Write($"{numero} x {i} = {numero * i}\n");
        }

        Console.Write("\nFIM DA TABUADA!\n\n");

        
    }
}

