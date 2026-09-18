using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MonProjet;

class Program
{
    static async Task Main(string[] args)
    {
        string? url = Console.ReadLine();
        if (url == null) return;


        string response = await GetResponse(url);
        SayHello(response);
    }
    static async Task<string> GetResponse(string url)
    {
        using HttpClient client = new HttpClient();
        return await client.GetStringAsync(url);
    }

    static void SayHello(string dest)
    {
        Console.WriteLine(dest);
    }
}