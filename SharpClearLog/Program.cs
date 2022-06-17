using System;
using System.Diagnostics;
class Program
{
    static void Main(string[] args)
    {
        string help = @"SharpClearLog.exe [-a] [-n LogName]
                        -a   Delete all Logs
                        -n   Delete logs in the specified log";
        if (args.Length == 0 || args[0] == "-h")
        {
            Console.WriteLine(help);
        }
        else if (args[0] == "-a")
        {
            foreach (var eventLog in EventLog.GetEventLogs())
            {
                eventLog.Clear();
                eventLog.Dispose();
            }
        }
        else if (args[0] == "-n" & args.Length == 2)
        {
            var eventLog = new EventLog(args[1], System.Environment.MachineName);
            eventLog.Clear();
        }
        else
        {
            Console.WriteLine(help);
        }

    }
}
