using System.Drawing;
using Microsoft.Extensions.Logging;
using Sharpie;
using Sharpie.Abstractions;

namespace RogueConsole.Core;

public sealed class GameState(ILogger logger, Style playerBody)
{
    public static event EventHandler<GamePhase> CurrentState;
    public static event Action? OnTick;

    public Point PrevPosition { get; set; }

    public required Canvas Canvas { get; set; }

    public enum Direction
    {
        down,
        up,
        left,
        right,
    }

    public bool InBounds(Point pos)
    {
        bool isInboundsX = pos.X > 0 && pos.X + 1 < Canvas.Size.Width;
        bool isInboundsY = pos.Y > 0 && pos.Y + 1 < Canvas.Size.Height;
        return isInboundsX && isInboundsY;
    }

    public void Update(Direction? direction)
    {
        Point position = direction switch
        {
            Direction.down => InBounds(PrevPosition with { Y = PrevPosition.Y + 1 })
                ? PrevPosition with
                {
                    Y = PrevPosition.Y + 1,
                }
                : PrevPosition,
            Direction.up => InBounds(PrevPosition with { Y = PrevPosition.Y - 1 })
                ? PrevPosition with
                {
                    Y = PrevPosition.Y - 1,
                }
                : PrevPosition,
            Direction.left => InBounds(PrevPosition with { X = PrevPosition.X - 1 })
                ? PrevPosition with
                {
                    X = PrevPosition.X - 1,
                }
                : PrevPosition,
            Direction.right => InBounds(PrevPosition with { X = PrevPosition.X + 1 })
                ? PrevPosition with
                {
                    X = PrevPosition.X + 1,
                }
                : PrevPosition,
            _ => PrevPosition,
        };

        Canvas.Glyph(PrevPosition, Assets.Assets.Space, Style.Default);
        Canvas.Glyph(position, Assets.Assets.Player, playerBody);
        PrevPosition = position;
    }
}

public enum GamePhase
{
    Running,
    GameOver,
    Victory,
}
