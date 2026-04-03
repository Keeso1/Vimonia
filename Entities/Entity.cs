namespace RogueConsole.Entities;

using RogueConsole.Core;
using RogueConsole.World;

public abstract class Entity
{
    public EntityType Type { get; init; }
    public int Health { get; set; }
    public int MaxHealth { get; set; }
    public bool IsDead => Health <= 0;
    protected TileMap _map;

    protected Entity(TileMap map, int health, int maxhealth, EntityType type)
    {
        Health = health;
        MaxHealth = maxhealth;
        _map = map;
        Type = type;
    }

    public virtual void Update()
    {
        // override per entity type
    }

    public virtual void CheckState(object? sender, GamePhase phase)
    {

    }


}

public enum EntityType
{
    Player,
    Enemy
}
