namespace MonProjet;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 1)
        {
            SayHello(args[0]);
        }
        else
        {
            SayHello("world");
        }
    }

    static void SayHello(string dest)
    {
        Console.WriteLine("Bonjour " + dest + "!");
    }
}