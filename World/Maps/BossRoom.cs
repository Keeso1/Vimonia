using Vimonia.Enums;
using Vimonia.Utils;
using Sharpie;

using Microsoft.Extensions.Logging;

namespace Vimonia.World.Maps;


public class BossRoom(Canvas canvas, ILogger logger) : TileMap(canvas, logger) {
    public override void InitMap() {
        base.InitMap();
        RoomType = RoomTypes.Boss;
        Set(GetCanvasCoords.GetCanvasTopCenter(Canvas).Add(0, 2).Clamp(canvas.Size), Tile.Goblin(_logger));
        Set(GetCanvasCoords.GetCanvasBottomCenter(Canvas).Subtract(0, 2).Clamp(canvas.Size), Tile.Goblin(_logger));
    }
}
