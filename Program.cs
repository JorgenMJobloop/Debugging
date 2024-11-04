namespace CS_Debugging;


class Program
{
    static void Main(string[] args)
    {
        // create a new instance of the HTTPClient class
        HTTPClient hTTPClient = new HTTPClient();

        Task task = Task.Run(hTTPClient.Run);
        Console.ReadLine();
    }
}
