using Vimonia.Enums;
using Vimonia.Utils;
using Sharpie;
using System.Drawing;

using Microsoft.Extensions.Logging;
using Vimonia.Core;

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
        var g1 = Rng.GetRandomFromCanvas();
        var g2 = Rng.GetRandomFromCanvas();

        Set(g1, Tile.Goblin(new(g1.Item1, g1.Item2)));
        Set(g2, Tile.Goblin(new(g2.Item1, g2.Item2)));
    }

}
