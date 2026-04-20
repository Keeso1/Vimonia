using System.Drawing;
using Vimonia.Enums;
using Vimonia.World;
namespace Vimonia.Interfaces;

public interface IEntity {
    int Health { get; }
    int MaxHealth { get; }
    EntityType Type { get; }
    Point Position { get; set; }
}
