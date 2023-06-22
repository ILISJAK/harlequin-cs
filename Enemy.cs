using System;
using System.Collections.Generic;

namespace harlequin_cs
{
    public class Enemy : Character
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Speed { get; set; }

        public Enemy(string name, int x, int y, int speed) : base(name)
        {
            X = x;
            Y = y;
            Speed = speed;
        }

        public void MoveTowardsPlayer(int playerX, int playerY, List<Enemy> otherEnemies)
        {
            int nextX = X;
            int nextY = Y;

            if (X < playerX) { nextX += Speed; }
            else if (X > playerX) { nextX -= Speed; }

            if (Y < playerY) { nextY += Speed; }
            else if (Y > playerY) { nextY -= Speed; }

            // Check for collisions with the player
            if (Math.Abs(nextX - playerX) <= Speed * 2 && Math.Abs(nextY - playerY) <= Speed * 2)
            {
                return; // Don't move if the enemy would collide with the player
            }

            // Check for collisions with other enemies
            foreach (var otherEnemy in otherEnemies)
            {
                if (otherEnemy != this && Math.Abs(nextX - otherEnemy.X) <= Speed * 2 && Math.Abs(nextY - otherEnemy.Y) <= Speed * 2)
                {
                    return; // Don't move if the enemy would collide with another enemy
                }
            }

            // If no collisions were detected, then move
            X = nextX;
            Y = nextY;
        }
    }
}
