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
    private ILogger _logger {get; set;}

    private int _tickCount = 0;
    protected Point _playerPos = new(0, 0);

    protected Entity(int health, int maxhealth, EntityType type) {
        Health = health;
        MaxHealth = maxhealth;
        Type = type;
        _logger = logger;


        GameState.PlayerInput += Update;
        GameState.CurrentState += CheckState;

    }

    protected virtual void Update(object sender, Point playerPos) {
        _tickCount++;
        if (IsDead) {
            GameState.CurrentState -= CheckState;
        }

    }

        _logger.LogInformation("EVENT: player pos: {pos}", _playerPos);

        }
    }

    protected void CheckState(object? sender, GamePhase phase) {
        if (phase is GamePhase.Running) return;
        if (phase is GamePhase.GameOver || phase is GamePhase.Victory) {
            GameState.OnTick -= Update;
            GameState.CurrentState -= CheckState;
        }

    }
}


