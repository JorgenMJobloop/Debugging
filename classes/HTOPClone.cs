using System.Diagnostics;

public class HTOPClone : IHTOPClone
{
    /*
        Author: https://github.com/jorgenmjobloop
        TODO: Properly utilize the System.Diagnostics namespace to inherit the PerformanceCounter class [error]
              Use Process to implement the MonitorUNIX method
              Use ManagementObjectSearcher to implement the MonitorWindows method
        /*     
    */
    public void MonitorUNIX()
    {
        ProcessStartInfo processStartInfo = new ProcessStartInfo
        {
            FileName = "/bin/bash", // invode the BASH shell process
            Arguments = "-c \"free -m\"",
            RedirectStandardInput = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        using (Process? process = Process.Start(processStartInfo))
        {
            string output = process.StandardOutput.ReadToEnd();
            Console.WriteLine(output);
        }
    }

    public void MonitorWindows()
    {
        // lack of experience with cmd & powershell, might not work as intended
        ProcessStartInfo winPSI = new ProcessStartInfo
        {
            FileName = "cmd.exe",
            Arguments = "/c wmic OS get FreePhysicalMemory, TotalVisibleMemorySize /Value",
            RedirectStandardOutput = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        using (Process? process = Process.Start(winPSI))
        {
            string output = process.StandardOutput.ReadToEnd();
            Console.WriteLine(output);
        }
    }
}