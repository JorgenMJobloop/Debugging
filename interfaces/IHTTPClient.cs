public interface IHTTPClient
{
    /// <summary>
    /// A async method that runs our HTTPClient class
    /// </summary>
    /// <returns></returns>
    Task Run();
    /// <summary>
    /// Write JSON data we fetch from a given API to a file
    /// </summary>
    /// <param name="path">the filepath on our system</param>
    /// <param name="content">content that will be written to the file</param>
    void WriteToFile(string path, string content);
}