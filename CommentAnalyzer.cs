using System;
using System.Net.Http;
using System.Threading.Tasks;

public class TwitterService
{
    private readonly HttpClient client = new HttpClient();

    public async Task GetTweetsAsync()
    {
        client.DefaultRequestHeaders.Add("Authorization", "Bearer YOUR_TOKEN");

        var response = await client.GetStringAsync(
            "https://api.twitter.com/2/tweets/search/recent?query=sustainability"
        );

        Console.WriteLine(response);
    }
}
