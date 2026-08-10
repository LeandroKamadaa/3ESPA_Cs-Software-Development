class Program
{
    static void Main)
    {
        Console.WriteLine("Qual seu nome?");
        string nome = Console.ReadLine();
        
        Console.writeLine("Qual sua idade?");
        int idade = Console.readLine();

        Console.WriteLine("Qual sua altura?");
        double altura = Console.ReadLine();

        Console.WriteLine("Qual seu peso?");
        double peso = Console.ReadLine();

        Console.WriteLine("Qual sua cidade?");
        var cidade = Console.ReadLine();
        
        Console.WriteLine($"Ola {nome}, {idade} anos, {altura}m de altura, {peso}kg, da cidade de {cidade}");
        
        string msg = $"Informações do nome{nome.Trim()}"
        console.WriteLine(msg);

    }
}