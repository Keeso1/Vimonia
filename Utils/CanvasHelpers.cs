using System.Drawing;
using System.Text;
using Microsoft.Extensions.Logging;
using Sharpie;
using Vimonia.World;

public static class CanvasHelpers
{

	public static void RenderToMap(ILogger logger, Canvas canvas, Rune[,] Tiles)
	{
		for (int w = 0; w < canvas.Size.Width; w++)
		{
			for (int h = 0; h < canvas.Size.Height; h++)
			{
				logger.LogInformation("w {w} \n h {h}", w, h); //TODO Fortsätt här
				canvas.Glyph(new Point(w, h), Tiles[w, h], Style.Default);
			}
		}
	}

    public static Rune[,] RoomsToString(ILogger logger, GameSettings settings, TileMap[,] Rooms, TileMap currentRoom) //Helper func to see the grid in a clean way
    {
		Rune[,] map = new Rune[(settings.NumberOfRooms +1) * 2,(settings.NumberOfRooms +1) * 2];
        for (int y = 0; y < Rooms.GetLength(1); y++)
        {
            for (int x = 0; x < Rooms.GetLength(0); x++)
            {
                if (Rooms[x, y] != null)
                {
                    map[x, y] = new Rune(Convert.ToInt32(Rooms[x, y].RoomType)); //dafuq
                }
                else
                {
                    map[x,y] = new Rune(0);
                }
            }
        }
        return map;
    }
}

