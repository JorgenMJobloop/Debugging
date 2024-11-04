namespace Utilities;
public class LGTUI()
{
    public void Send(string message)
    {
        Console.WriteLine(message);
    }

    public int RequestInt()
    {
        int result;
        bool suceess = false;

        do
        {
            Console.WriteLine("Format: XXXX");

            var raw = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(raw))
            {
                Console.WriteLine("Please provide a input string");
                continue;
            }

            suceess = int.TryParse(raw, out result);

            if (suceess)
            {
                return result;
            }
        } while (!suceess);

        throw new FormatException();
    }

    public DateOnly RequestDate()
    {
        DateOnly result;
        bool suceess = false;

        do
        {
            Console.WriteLine("Format: YYYY-MM-DD");

            var raw = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(raw))
            {
                Console.WriteLine("Please provide a non empty input");
                continue;
            }

            suceess = DateOnly.TryParse(raw, out result);

            if (suceess)
            {
                return result;
            }
        } while (!suceess);

        throw new FormatException();
    }

    public TimeOnly RequestTime()
    {
        TimeOnly result;
        bool suceess = false;

        do
        {
            Console.WriteLine("Format: HH:MM:SS");

            var raw = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(raw))
            {
                Console.WriteLine("Please provide a non empty input");
                continue;
            }

            suceess = TimeOnly.TryParse(raw, out result);

            if (suceess)
            {
                return result;
            }
        } while (!suceess);

        throw new FormatException();
    }
}