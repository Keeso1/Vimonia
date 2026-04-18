using Vimonia.Enums;
using Vimonia.Utils;
using Sharpie;
using System.Drawing;

using Microsoft.Extensions.Logging;
using Vimonia.Core;

namespace Vimonia.World.Maps;


public class NormalRoom: TileMap{

    public List<Point> Enemies {get; set;} = [];
    private Canvas canvas1 {get; set;}
    private ILogger _logger {get; set;}

    public NormalRoom(Canvas canvas, ILogger logger) : base(canvas, logger){
        canvas1 = canvas;
        _logger = logger;
        GameState.PlayerInput += Update;
    }


    public async void Update(object? sender, Point playerPos){
        await UpdatePos(playerPos);

    }

    private async Task UpdatePos(Point playerPos){
        for(int i = 0; i < Enemies.Count; i++){
            UnSet(Enemies[i]);
            Cardinals direction = (Cardinals)Rng.GetRandom().Next(0,4);
            Enemies[i] = Enemies[i].IncrementCardinal(direction);
            Set(Enemies[i], Tile.Goblin(Enemies[i]));
        }
    }

    public async Task GenerateEnemies(){
        int numberOfEnemies = Rng.GetRandom().Next(1,10);
        for(int num = 0; num < numberOfEnemies; num++){
            Enemies.Add(Rng.GetRandomFromCanvas().ToPoint());
        }
    }

    public async override void InitMap() {
        base.InitMap();
        RoomType = RoomTypes.Normal;

        await GenerateEnemies();
        foreach(Point enemyPos in Enemies){
            Set(enemyPos, Tile.Goblin(enemyPos));
        }
    }

}
