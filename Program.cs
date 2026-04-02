using Sharpie;
using Sharpie.Backend;

internal class Program
{
    private static void Main(string[] args)
    {
        var backend = CursesBackend.Load();
        using var terminal = new Terminal(backend, new TerminalOptions(UseMouse: false));

        terminal.Screen.DrawBorder();
        terminal.Screen.Refresh();

        foreach (var @event in terminal.Events.Listen(terminal.Screen))
        {
            if (@event is KeyEvent)
                break;
        }
    }
}
