namespace RogueConsole.World;

using RogueConsole.Entities;
using RogueConsole.Assets;
using System.Text;

public class Tile
{
	public Rune Glyph { get; set; }
	public Entity? Entity { get; set; }
	public bool Walkable { get; set; } = false;
	public bool Visible { get; set; } = true;

	public static Tile Floor => new() { Glyph = Assets.Ground, Walkable = true };
	public static Tile Wall => new() { Glyph = Assets.Wall };
	public static Tile Enemy => new() { Glyph = Assets.Enemy };
	public static Tile Player => new() { Glyph = Assets.Player };
}


