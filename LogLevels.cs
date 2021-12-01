using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        int position = logLine.IndexOf(":") + 1;
        string phrase = logLine.Substring(position, logLine.Length - position);
        return phrase.Trim();
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
        string msgNotLevels = Message(logLine);
        string warningLevels = LogLevel(logLine);
        return $"{msgNotLevels} ({warningLevels})";
    }
}