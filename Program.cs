using System.Drawing;
using System.Text;
using RogueConsole.Assets;
using RogueConsole.Core;
using Sharpie;
using Sharpie.Abstractions;
using Sharpie.Backend;

var terminal = new Terminal(
    CursesBackend.Load(),
    new TerminalOptions(UseColors: true, CaretMode: CaretMode.Invisible, UseMouse: false)
);

Canvas canvas = new(terminal.Screen.Size);

var game = new GameState(
    new()
    {
        Attributes = VideoAttribute.Bold,
        ColorMixture = terminal.Colors.MixColors(StandardColor.Magenta, StandardColor.Black),
    }
)
{
    Canvas = canvas,
    PrevPosition = new(terminal.Screen.Size.Width / 2, terminal.Screen.Size.Height / 2),
};

terminal.Repeat(
    t =>
    {
        game.Canvas.DrawOnto(
            t.Screen,
            new Rectangle(new Point(0, 0), canvas.Size),
            new Point(0, 0)
        );
        t.Screen.Refresh();
        t.Screen.DrawBorder();
        return Task.CompletedTask;
    },
    50
);

terminal.Run(
    (Term, Tevent) =>
    {
        switch (Tevent)
        {
            case KeyEvent { Char.Value: 'q' }:
                Environment.Exit(0);
                break;
            case KeyEvent { Char.Value: 'h' }:
                game.Update(GameState.Direction.left);
                break;

            case KeyEvent { Char.Value: 'j' }:
                game.Update(GameState.Direction.down);
                break;
            case KeyEvent { Char.Value: 'k' }:
                game.Update(GameState.Direction.up);
                break;
            case KeyEvent { Char.Value: 'l' }:
                game.Update(GameState.Direction.right);
                break;
        }
        ;
        return Task.FromResult(true);
    }
);
