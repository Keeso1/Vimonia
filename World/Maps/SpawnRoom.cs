using Vimonia.Enums;
using Sharpie;

using Microsoft.Extensions.Logging;

namespace Vimonia.World.Maps;

public class SpawnRoom(Canvas canvas, ILogger logger) : TileMap(canvas, logger) {
    public override void InitMap() {
        RoomType = RoomTypes.Spawn;
        base.InitMap();
    }
}
