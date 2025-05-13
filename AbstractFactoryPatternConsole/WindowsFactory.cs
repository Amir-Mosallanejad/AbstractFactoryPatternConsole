namespace AbstractFactoryPatternConsole;

public class WindowsFactory : IGUIFactory
{
    public IButton CreateButton()
    {
        return new WindowsButton();
    }
}