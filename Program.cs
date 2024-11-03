namespace CS_Debugging;

class Program
{
    static void Main(string[] args)
    {
        HTOPClone hTOPClone = new HTOPClone();
        HTTPClient hTTPClient = new HTTPClient();


        //hTOPClone.MonitorWindows();

        Task task = Task.Run(hTTPClient.Run);
    }
}
