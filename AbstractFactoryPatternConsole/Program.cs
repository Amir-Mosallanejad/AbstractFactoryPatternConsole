using AbstractFactoryPatternConsole;

IGUIFactory factory;

string os = "Windows";
if (os == "Windows")
{
    factory = new WindowsFactory();
}
else
{
    factory = new MacFactory();
}

Application app = new Application(factory);
app.RenderUI();