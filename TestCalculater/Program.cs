// See https://aka.ms/new-console-template for more information

CalculaterHelper CalculaterHelper = new CalculaterHelper();
Console.WriteLine(CalculaterHelper.Sum(2,5));

public class CalculaterHelper
{
    public int Sum(int x, int y)
    {
        return x + y;
    }
}
