public interface IHTOPClone
{
    /// <summary>
    /// A method that utilizes the Process class in UNIX systems (Linux & MacOS)
    /// </summary>
    void MonitorUNIX();
    /// <summary>
    /// A method that monitors any given Windows System above 10 (including Windows Server 2012 + )
    /// </summary>
    void MonitorWindows();
}