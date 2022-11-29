using System;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        bool result = true;
        var sort = word.Replace(" ", "").Replace("-", "").ToLower();
        for(int i=0; i<sort.Length; i++)
        {
            for(int j=0; j<i; j++)
            {
                if(sort[j] == sort[i])
                    result = false;
            }
        }
        return result;
    }
}