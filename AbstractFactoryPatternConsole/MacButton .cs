using System.Threading.Channels;

namespace AbstractFactoryPatternConsole;

public class MacButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Render Mac Button");
    }
}
