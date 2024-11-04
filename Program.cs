namespace CS_Debugging;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //DateTime dateTime = new DateTime();
        int day;
        int month;
        int year;

        Int32.TryParse(Console.ReadLine(), out day);
        Int32.TryParse(Console.ReadLine(), out month);
        Int32.TryParse(Console.ReadLine(), out year);

        DateOnly dateOnly = new DateOnly(year, month, day);

        Console.WriteLine(dateOnly.ToLongDateString());

        int minutes;
        int hours;
        int seconds;

        Int32.TryParse(Console.ReadLine(), out minutes);
        Int32.TryParse(Console.ReadLine(), out hours);
        Int32.TryParse(Console.ReadLine(), out seconds);

        TimeOnly timeOnly = new TimeOnly(minutes, hours, seconds);
        Console.WriteLine(timeOnly);
        var dotEnv = File.ReadAllLines(".env");

        foreach (string dot in dotEnv)
        {
            Console.WriteLine(dot);
        }

        // create a new instance of the HTTPClient class
        HTTPClient hTTPClient = new HTTPClient();
        //Task task = Task.Run(hTTPClient.Run);
        Console.ReadLine();
    }
}
