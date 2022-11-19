using System;
using System.Collections.Generic;

public static class Languages
{
    public static List<string> NewList()
    {
        return new List<string>();
    }

    public static List<string> GetExistingLanguages()
    {
        var listLanguages = NewList();
        listLanguages.Add("C#");
        listLanguages.Add("Clojure");
        listLanguages.Add("Elm");
        return listLanguages;
    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        languages.Add(language);
        return languages;
    }

    public static int CountLanguages(List<string> languages)
    {
        return languages.Count;
    }

    public static bool HasLanguage(List<string> languages, string language)
    {
        bool fff = false;
        for(int i=0; i < languages.Count; i++)
        {
            if(languages[i] == language)
            {
                fff = true;
            }
        }
        return fff;
    }

    public static List<string> ReverseList(List<string> languages)
    {
        languages.Reverse();
        return languages;
    }

    public static bool IsExciting(List<string> languages)
    {
        return ((languages.Count >= 1 && languages[0] == "C#") ||
            ((languages.Count == 2 || languages.Count == 3) && languages[1] == "C#"));
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        for(int i=0; i<languages.Count; i++)
        {
            if(languages[i] == language)
            {
                languages.RemoveAt(i);
            }
        }
        return languages;
    }

    public static bool IsUnique(List<string> languages)
    {
        bool result = true;
        for(int i=0; i < languages.Count; i++)
        {
            for(int j=0; j < i; j++)
            {
                if(languages[i] == languages[j])
                    result = false;
            }
        }
        return result;
    }
}
