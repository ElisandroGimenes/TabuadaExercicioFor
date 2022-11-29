class Program
{
    public static void Main(String[] args)
    {
        int numero;

        Console.Write("Digite o número da tabuada: ");
        
        numero = int.Parse(Console.ReadLine());
        
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(numero + " X " + i + " = " + numero * i);
        }
    }
}
