using System;

public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();
        if((statement.EndsWith('?')) && (statement == statement.ToUpper()) && (statement.ToLower() != statement))
            return "Calm down, I know what I'm doing!";
        else if((statement.ToUpper() == statement && statement.ToLower() != statement))
            return "Whoa, chill out!";
        else if(statement.EndsWith('?')) 
            return "Sure.";
        else if(string.IsNullOrWhiteSpace(statement))
            return "Fine. Be that way!";
        else 
            return "Whatever.";
    }
}