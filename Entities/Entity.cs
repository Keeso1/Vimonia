using System.Drawing;
using Microsoft.Extensions.Logging;
using Vimonia.Core;
using Vimonia.Enums;

namespace Vimonia.Entities;


public abstract class Entity {

    public EntityType Type { get; init; }
    public int Health { get; set; }
    public int MaxHealth { get; set; }
    public bool IsDead => Health <= 0;
    public Point Position {get; set;}

    private int _tickCount = 0;
    protected Point _playerPos = new(0, 0);

    protected Entity(Point position, int health, int maxhealth, EntityType type) {
        Health = health;
        MaxHealth = maxhealth;
        Type = type;
        Position = position;

        GameState.PlayerInput += Update;
        GameState.CurrentState += CheckState;

    }

    protected virtual void Update(object sender, Point playerPos) {
        _tickCount++;
        if (IsDead) {
            GameState.CurrentState -= CheckState;
        }

        _playerPos = playerPos;

        Direction[] directions = Enum.GetValues<Direction>();
        Controls.Move(directions[Rng.GetRandom().Next(0,3)], Position);

    }

    // protected void CheckPlayer() {
    //     if (_tickCount % 2 == 0) {
    //         _playerPos = new(2, 2); //TODO: FIX THIS
    //
    //     }
    // }

    protected void CheckState(object? sender, GamePhase phase) {
        if (phase is GamePhase.Running) return;
        if (phase is GamePhase.GameOver || phase is GamePhase.Victory) {
            GameState.CurrentState -= CheckState;
        }

    }
}


