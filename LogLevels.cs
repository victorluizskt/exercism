using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        return "Vazio";
    }

    public static string LogLevel(string logLine)
    {
        char second = logLine[1];
        if(second == 'I')
        {
            return "info";
        } 
    
        if(second == 'W')
        {
            return "warning";
        }

        return "error";
    }

    public static string Reformat(string logLine)
    {
        return "Operation completed (info)";
    }
}