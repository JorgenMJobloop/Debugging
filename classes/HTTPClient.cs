using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

public class HTTPClient : IHTTPClient
{
    HttpClient httpClient = new HttpClient();

    public async Task Run()
    {
        // we use the HttpResponseMessage to make a call to a RestAPI online, and we use the GET method by
        // utilizing the GetAsync() method
        HttpResponseMessage response = await httpClient.GetAsync("https://api.nobelprize.org/2.1/nobelPrizes");

        try
        {

            var content = await response.Content.ReadAsStringAsync(); // await content from any given API that we pass as a argument to the call in the httpClient object

            string? jsonData = JsonSerializer.Serialize(content);

            Console.WriteLine(JsonSerializer.Deserialize<string>(jsonData));

            //            Console.WriteLine(JsonSerializer.Deserialize<string>(jsonData));
            //WriteToFile("nobel.json", JsonSerializer.Deserialize<string>(jsonData));
            WriteToFile("test_nobel.json", content);
        }

        catch (HttpRequestException exception)
        {
            Console.WriteLine($"A HTTP request error occured: {exception.ToString()}");
        }
        finally
        {
            httpClient.Dispose(); // dispose of the client session
        }
    }

    public void WriteToFile(string path, string content)
    {
        if (string.IsNullOrWhiteSpace(path) && string.IsNullOrWhiteSpace(content))
        {
            Console.WriteLine("Could not open the filestream!");
        }
        else if (!File.Exists(path))
        {
            File.Create(path);
        }

        try
        {
            File.WriteAllText(path, content);
        }
        catch (Exception exception)
        {
            Console.WriteLine($"Error occurend when opening the filestream: {exception.Message}");
        }
    }
}