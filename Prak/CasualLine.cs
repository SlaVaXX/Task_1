namespace Prak;

public class CasualLine
{
    protected string? Line;

    public CasualLine(string? NewLine)
    {
        if (NewLine != null)
        {
            Line = NewLine.Replace(" ","");
        }
    }

    public int LineLength()
    {
        return Line.Length;
    }
}