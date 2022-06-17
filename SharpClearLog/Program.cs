using System;
using System.Diagnostics;
class Program
{
    static void Main(string[] args)
    {
        var eventLog = new EventLog("Security", System.Environment.MachineName);
        eventLog.Clear();

    }
}
