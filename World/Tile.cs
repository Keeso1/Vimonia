using Vimonia.Entities;
using Vimonia.Assets;
using System.Text;
using Microsoft.Extensions.Logging;

namespace Vimonia.World;


public class Tile {

    public ILogger? Logger {get; set;} = null;

    public Tile(ILogger? logger){
        Logger = logger;
    }
    public Rune Glyph { get; set; }
    public Entity? Entity { get; set; }
    public bool Walkable { get; set; } = false;
    public bool Visible { get; set; } = true;

    public static Tile Floor(ILogger? logger) => new(logger) { Glyph = GameConstants.Ground, Walkable = true };
    public static Tile Wall(ILogger? logger) => new(logger) { Glyph = GameConstants.Wall };
    public static Tile Goblin(ILogger? logger) => new(logger) { Glyph = GameConstants.Enemy, Entity = new Goblin(100, 100, logger!) };
    public static Tile Player(ILogger? logger) => new(logger) { Glyph = GameConstants.Player };
    public static Tile Chest(ILogger? logger) => new(logger) { Glyph = GameConstants.Item };
    public static Tile Door(ILogger? logger) => new(logger) { Glyph = GameConstants.Door, Walkable = true };
    public static Tile Rock(ILogger? logger) => new(logger) { Glyph = GameConstants.Rock };
}


