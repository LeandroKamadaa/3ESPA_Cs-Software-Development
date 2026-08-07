class Program
{
    static void Main()
    {
        Console.WriteLine("Qual seu nome?");
        string nome = Console.ReadLine();

        Console.WriteLine("Qual sua idade?");
        string idade = Console.ReadLine();

        Console.WriteLine("Qual seu curso?");
        string curso = Console.ReadLine();

        Console.WriteLine($"Ola {nome}, {idade} anos do curso de {curso}");
    }
}