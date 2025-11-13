using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

public class TwitterService
{
    private readonly HttpClient client = new HttpClient();

    public async Task GetPostsAsync()
    {
        // API تستی که JSON شبیه پست‌ها را برمی‌گرداند
        var response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts/1");
        var body = await response.Content.ReadAsStringAsync();

        // تبدیل JSON → Post
        var post = JsonSerializer.Deserialize<Post>(body);

        Console.WriteLine("=== Title ===");
        Console.WriteLine(post.title);
        Console.WriteLine();

        Console.WriteLine("=== Body ===");
        Console.WriteLine(post.body);
    }
}
