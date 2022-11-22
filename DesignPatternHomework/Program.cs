namespace Homework1;

public interface IButton
{
    void Render();
    void OnClick();
}

public class WindowsButton : IButton
{
    public void OnClick() => Console.WriteLine("Windows button Click");
    public void Render() => Console.WriteLine("Windows button Render");
}

public class WebButton : IButton
{
    public void OnClick() => Console.WriteLine("Web button Click");
    public void Render() => Console.WriteLine("Web render Render");
}


public abstract class Dialog
{
    public void render()
    {
        IButton okButton = CreateButton();
        okButton.OnClick();
        okButton.Render();
    }

    public abstract IButton CreateButton();
}

public class WindowsDialog : Dialog
{
    public override IButton CreateButton() => new WindowsButton();
}

public class HtmlDialog : Dialog
{
    public override IButton CreateButton() => new WebButton();
}

public class Program
{
    public static void Main()
    {
        Dialog MAUI = new WindowsDialog();
        MAUI.render();
        MAUI = new HtmlDialog();
        MAUI.render();
    }
}