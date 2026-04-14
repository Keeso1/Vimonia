using Vimonia.Enums;
using Vimonia.Utils;
using Sharpie;

namespace Vimonia.World.Maps;


public class MiniMap(Canvas canvas, TileMap currentRoom) : TileMap(canvas)
{
	public override void InitMap()
	{
		//TODO: Add logic to transform the stringified mutlidimensional array of rooms. !! Also inject floor as a dependency 
		//and run function to get the currentRoom from the floor mutlidimensional array
        Tiles = new Tile[Canvas.Size.Width, Canvas.Size.Height];
        Fill();
	}

}
