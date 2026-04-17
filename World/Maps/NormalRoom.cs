using Vimonia.Enums;
using Vimonia.Utils;
using Sharpie;
using System.Drawing;

using Microsoft.Extensions.Logging;

namespace Vimonia.World.Maps;


public class NormalRoom: TileMap{

    public List<Point> Enemies {get; set;}
    private Canvas canvas1 {get; set;}

    public NormalRoom(Canvas canvas, ILogger logger) : base(canvas, logger){
        canvas1 = canvas;
    }

    public override void InitMap() {
        base.InitMap();
        RoomType = RoomTypes.Normal;
        Set(GetCanvasCoords.GetCanvasTopCenter(Canvas).Add(0, 2).Clamp(canvas1.Size), Tile.Goblin(_logger));
        Set(GetCanvasCoords.GetCanvasBottomCenter(Canvas).Subtract(0, 1).Clamp(canvas1.Size), Tile.Goblin(_logger));
    }

}
