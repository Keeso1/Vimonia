using System.Drawing;
using Sharpie;
using Vimonia.Enums;

public static class Controls{

    public static Point Move(Canvas canvas, Direction? direction, Point PrevPosition){
        Point position = direction switch
        {
            Direction.Down => PrevPosition with
            {
                Y = Math.Clamp(PrevPosition.Y + 1, 0, canvas.Size.Height - 1),
            },
            Direction.Up => PrevPosition with {
                Y = Math.Clamp(PrevPosition.Y - 1, 0, canvas.Size.Height - 1),
            },
            Direction.Left => PrevPosition with {
                X = Math.Clamp(PrevPosition.X - 1, 0, canvas.Size.Width - 1),
            },
            Direction.Right => PrevPosition with {
                X = Math.Clamp(PrevPosition.X + 1, 0, canvas.Size.Width - 1),
            },
            _ => PrevPosition,
        };
        return position;
    }
}
