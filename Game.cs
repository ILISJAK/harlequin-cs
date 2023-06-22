using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace harlequin_cs
{
    public class Game
    {
        public Player Player { get; set; }
        public int CharacterX { get; set; }
        public int CharacterY { get; set; }
        public int Step { get; set; }

        Random rnd = new Random();
        public List<Enemy> Enemies { get; set; }
        private Dictionary<char, bool> _keys;

        public Game(string playerName)
        {
            Player = new Player(playerName);
            CharacterX = 0;
            CharacterY = 0;
            Step = Player.MovementSpeed;

            int gameWidth = 1920;
            int gameHeight = 1080;
            int spawnArea = 1000; // Enemies can spawn up to 1000 pixels outside the game area

            Enemies = new List<Enemy>()
            {
                new Enemy("enemy", rnd.Next(-spawnArea, gameWidth + spawnArea), rnd.Next(-spawnArea, gameHeight + spawnArea), 5),
                new Enemy("enemy", rnd.Next(-spawnArea, gameWidth + spawnArea), rnd.Next(-spawnArea, gameHeight + spawnArea), 5),
                new Enemy("enemy", rnd.Next(-spawnArea, gameWidth + spawnArea), rnd.Next(-spawnArea, gameHeight + spawnArea), 5)
            };

            _keys = new Dictionary<char, bool>
            {
                {'w', false},
                {'a', false},
                {'s', false},
                {'d', false}
            };
        }

        public void KeyDown(KeyEventArgs e)
        {
            char key = char.ToLowerInvariant(e.KeyCode.ToString()[0]);
            if (_keys.ContainsKey(key))
            {
                _keys[key] = true;
            }
        }

        public void KeyUp(KeyEventArgs e)
        {
            char key = char.ToLowerInvariant(e.KeyCode.ToString()[0]);
            if (_keys.ContainsKey(key))
            {
                _keys[key] = false;
            }
        }

        public void Update(int limitX, int limitY)
        {
            foreach (var key in _keys.Keys)
            {
                if (_keys[key])
                {
                    MoveCharacter(key, limitX, limitY);
                }
            }

            // Move enemies towards the player
            foreach (var enemy in Enemies)
            {
                enemy.MoveTowardsPlayer(CharacterX, CharacterY, Enemies);
            }
        }


        private void MoveCharacter(char direction, int limitX, int limitY)
        {
            switch (direction)
            {
                case 'w': // Up
                    if (CharacterY > 0)
                    {
                        CharacterY -= Step;
                    }
                    break;

                case 's': // Down
                    if (CharacterY < limitY - Step)
                    {
                        CharacterY += Step;
                    }
                    break;

                case 'a': // Left
                    if (CharacterX > 0)
                    {
                        CharacterX -= Step;
                    }
                    break;

                case 'd': // Right
                    if (CharacterX < limitX - Step)
                    {
                        CharacterX += Step;
                    }
                    break;
            }
        }
    }
}
