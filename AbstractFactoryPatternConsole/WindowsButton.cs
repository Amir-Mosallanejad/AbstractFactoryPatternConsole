namespace AbstractFactoryPatternConsole;

public class WindowsButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Render Windows Button");
    }
}
