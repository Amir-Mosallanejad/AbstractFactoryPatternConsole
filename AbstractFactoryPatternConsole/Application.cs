﻿namespace AbstractFactoryPatternConsole;

public class Application
{
    private readonly IButton _button;

    public Application(IGUIFactory factory)
    {
        _button = factory.CreateButton();
    }

    public void RenderUI()
    {
        _button.Render();
    }
}
