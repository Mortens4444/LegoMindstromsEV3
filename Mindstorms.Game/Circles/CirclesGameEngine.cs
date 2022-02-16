﻿using Mindstorms.Core;
using Mindstorms.Core.EV3;
using Mindstorms.Core.Responses;
using Mindstorms.Game.Circles;
using Mindstorms.Game.General;
using System;
using System.Collections.Generic;

namespace Mindstorms.Game.Snake
{
    public class CirclesGameEngine : GameEngineBase
    {
        private MovingHandler movingHandler;

        private CircleEater player;
        private IList<CircleEater> enemies;
        private readonly Random random = new Random(Environment.TickCount);

        private const int NumberOfEnemies = 15;

        public CirclesGameEngine(Brick brick) : base(brick)
        { }

        protected override void StartNewGame()
        {
            inGame = true;
            message = "Game over!";
            player = new CircleEater(LCDCommand.HorizontalCenter, LCDCommand.VerticalCenter, 4);
            movingHandler = new MovingHandler(player);
            enemies = new List<CircleEater>();

            for (int i = 0; i < NumberOfEnemies; i++)
            {
                CircleEater enemy;
                do
                {
                    enemy = new CircleEater((byte)random.Next(2, 10));
                }
                while (player.IsColliding(enemy));
                enemies.Add(enemy);
            }
        }

        protected override ButtonStates GameMoment()
        {
            player.Move();
            bool drawPlayer = true;

            if (inGame)
            {
                if (!(player.GetCollidingCircle(enemies) is CircleEater enemy))
                {
                    for (byte enemyIndex = 0; enemyIndex < enemies.Count; enemyIndex++)
                    {
                        var currentEnemy = enemies[enemyIndex];
                        currentEnemy.ChangeMoving();
                        currentEnemy.Move();
                        brick.Draw(currentEnemy);
                    }
                }
                else
                {
                    if (player.Radius >= enemy.Radius)
                    {
                        enemies.Remove(enemy);
                        brick.Draw(player);
                        player.IncrementRadius((byte)(enemy.Radius / 4));
                        if (enemies.Count == 0)
                        {
                            message = "You won!";
                            inGame = false;
                        }
                    }
                    else
                    {
                        message = "Game over!";
                        drawPlayer = false;
                        brick.Draw(enemy);
                        inGame = false;
                    }
                }

                if (drawPlayer)
                {
                    brick.Draw(player);
                }
            }

            return movingHandler.HandleKeyPress(brick);
        }
    }
}
