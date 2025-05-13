namespace AbstractFactoryPatternConsole;

public class MacFactory : IGUIFactory
{
    public IButton CreateButton()
    {
        return new MacButton();
    }
}
