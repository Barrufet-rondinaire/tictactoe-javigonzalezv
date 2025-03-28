using System.Text.RegularExpressions;

namespace TicTacToe;

class Program
{
    
    // docker run -d --rm  -ti -p 8080:8080 utrescu/tictactoeapi:latest
    //pattern: participant ([A-Z][a-z]+ [A-Z-'a-z]+\w+).*representa( a|nt de) ([A-Z]\w+)
    
    static async Task Main(string[] args)
    {
        var baseUrl = "http://localhost:8080";
        var uri = new Uri(baseUrl);

        using HttpClient client = new()
        {
            BaseAddress = uri
        };
        string participants = await client.GetStringAsync("jugadors");

        string pattern = @"participant ([A-Z][a-z]+ [A-Z-'a-z]+\w+).*representa(?: a|nt de) ([A-Z]\w+)";
        Regex regex = new Regex(pattern);
        
        var matches = regex.Matches(participants);

        var nomJugador = new Dictionary<string, string>();
        var paisJugador = new Dictionary<string, int>();

        foreach (var linea in participants)
        {
            
            
            
            
            /*foreach (Match match in matches)
            {
                if (match.Success)
                {
                    var nom = match.Groups[0].Value;
                    var pais = match.Groups[2].Value;
                    Console.WriteLine($"Participant: {nom} - País: {pais}");
                }
            }*/
        }


    }
}

        
        
    
