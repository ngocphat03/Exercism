using System;
public static class LogAnalysis 
{
    
    public static string SubstringAfter(this String input, string start)
    { 
        return input.Substring(input.IndexOf(start) + start.Length);
    }
    public static string SubstringBetween(this String input, string start, string end)
    { 
        return input.Substring(input.IndexOf(start) + start.Length, input.IndexOf(end) - (input.IndexOf(start) + start.Length)); 
    }
    public static string Message(this String input)
    { 
        return input.Substring(input.IndexOf(":")+1).Trim();
    }
    public static string LogLevel(this String input)
    { 
        return input.SubstringBetween("[", "]");
    }
}