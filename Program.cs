namespace programa_da_tabuada;

class Program
{
    static void Main(string[] args)
    {

        
        Console.WriteLine("\nDigite um número pra ver sua tabuada: \n"); // Pede que o usuário informe um número pra ver sua tabuada
        int numero = Convert.ToInt32(Console.ReadLine()); // Converte o número texto pra uma variável do tipo INTEIRO
        Console.Write("\n"); // Escreve uma linha em branco

        for (int i = 0; i <= 10; i++) // Repete o multiplicador de 0 até 10 sempre somando + 1 a cada iteração
        {
            Console.Write($"{numero} x {i} = {numero * i}\n"); // Escreve as linhas da tabuada
        }

        Console.Write("\nFIM DA TABUADA!\n\n"); // Escreve FIM DA TABUADA

        
    }
}

