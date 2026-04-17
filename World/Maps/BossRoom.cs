using Vimonia.Enums;
using Sharpie;

using Microsoft.Extensions.Logging;
using Vimonia.Core;

namespace Vimonia.World.Maps;


public class BossRoom(Canvas canvas, ILogger logger) : TileMap(canvas, logger) {
    public override void InitMap() {
        base.InitMap();
        RoomType = RoomTypes.Boss;
        var g1 = Rng.GetRandomFromCanvas();
        var g2 = Rng.GetRandomFromCanvas();
        Set(g1, Tile.Goblin(new(g1.Item1, g1.Item2)));
        Set(g2, Tile.Goblin(new(g2.Item1, g2.Item2)));
    }
}
