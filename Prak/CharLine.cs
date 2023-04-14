using System.Text.RegularExpressions;
using System.Xml;

namespace Prak;

public class CharLine : CasualLine
{
    public CharLine() : base(null)
    {
    }
    public CharLine(string NewLine) : base(RemoveIntegers(NewLine))
    {
    }

    private static string RemoveIntegers(string NewLine)
    {
        return Regex.Replace(NewLine, @"[\d-]", string.Empty);
    }

    public void PrintString()
    {
        Console.WriteLine($"\nРядок: \"{Line}\"");
    }

    public string ReplaceChar(string OldChar, string NewChar)
    {
        try
        {
            Line = Line.Replace(OldChar, NewChar);
        }
        catch (Exception)
        {
            throw new Exception("\nНевказаний символ, який хочете замінити!");
        }
        return Line;
    }

    public string GetCharLine()
    {
        return Line;
    }
}