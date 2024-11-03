using System.Net.Http;
using System.Text.Json;

public class HTTPClient : IHTTPClient
{
    HttpClient httpClient = new HttpClient();

    public async Task Run()
    {
        HttpResponseMessage response = await httpClient.GetAsync("https://api.met.no/weatherapi/locationforecast/2.0/compact?lat=60.10&lon=9.58  ");
        try
        {
            response.EnsureSuccessStatusCode(); // throw an exception if the status code is not 200
            var content = await response.Content.ReadAsStringAsync(); // await content from any given API that we pass as a argument to the call in the httpClient object
            Console.WriteLine(JsonDocument.Parse(content));
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
}