using RogueConsole.Utils;
using Sharpie;

namespace RogueConsole.World.Maps;

public class ItemRoom(int width, int height, Canvas canvas) : TileMap(width, height, canvas)
{

	protected override void InitMap()
	{
		base.InitMap();
		var (c1, c2) = GetCanvasCoords.GetCanvasTopLeft();
		Set((c1 + 1, c1 + 1), Tile.Chest);
	}
}
