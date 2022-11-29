using System;

public static class ResistorColorDuo
{
    public static int Value(string[] colors)
    {
        string[] listColors = new[] {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };

        return Array.IndexOf(listColors, colors[0]) * 10 + Array.IndexOf(listColors, colors[1]);
    }
}
