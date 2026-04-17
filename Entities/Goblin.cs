using System.Drawing;
using Microsoft.Extensions.Logging;
using Vimonia.Core;
using Vimonia.Enums;

namespace Vimonia.Entities;

public class Goblin(int health, int maxHealth) : Entity(health, maxHealth, EntityType.Enemy) {
    protected override void Update() {
        base.Update();
        CheckPlayer();
    }
}
