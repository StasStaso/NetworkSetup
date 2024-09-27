namespace NetworkSetup.Model;

public class Logger
{
    public event Action<string> LogAdded;

    public void AddLog(string log) 
    {
        LogAdded?.Invoke(log);
    }
}
