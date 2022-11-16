using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        string rutGonMess = logLine.Remove(logLine.IndexOf("["), logLine.IndexOf(" ")).Trim();
        return rutGonMess;
    }

    public static string LogLevel(string logLine)
    {
        string justGetFirstWord = logLine.Substring(logLine.IndexOf("[")+1, logLine.IndexOf("]")-1).ToLower();
        return justGetFirstWord;
    }

    public static string Reformat(string logLine)
    {
        string onlyOneWord = logLine.Substring(logLine.IndexOf("["), logLine.IndexOf(":")).ToLower().Replace("[", " (").Replace("]",")");
        string rutGonChuoi = logLine.Remove(logLine.IndexOf("["), logLine.IndexOf(" ")).Trim();
        string stringPlusProVjp = String.Concat(rutGonChuoi, onlyOneWord);
        return stringPlusProVjp;
    }
}