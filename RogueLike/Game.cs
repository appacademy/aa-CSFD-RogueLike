using System;

namespace RogueLike
{
    public class Game
    {

        // constants
        private const int Width = 10;
        private const char WallCharacter = 'M';
        private const string EmptyCharacter = " ";

        private Hero _hero;
        private Treasure _treasure;
        private bool _isOver;

        public void Run()
        {
            SetUp();
            while (!_isOver)
            {
                PrintWorld();
                Move();
            }
            PrintWorld();
        }

        private void SetUp()
        {
            Random rand = new Random();
            int x = rand.Next(Width);
            int y = rand.Next(Width);
            Console.Write("Enter your hero's name: ");
            string name = Console.ReadLine();
            _hero = new Hero(x, y,name);

            do
            {
                x = rand.Next(Width);
                y = rand.Next(Width);
            } while (x == _hero.X && y == _hero.Y);

            _treasure = new Treasure(x, y);
        }

        private void PrintWorld()
        {
            Console.Clear();
            // top wall border
            Console.WriteLine(new string(WallCharacter, Width + 2));

            for (int row = 0; row < Width; row++)
            {
                // left wall border
                Console.Write(WallCharacter);
                for (int col = 0; col < Width; col++)
                {
                    if (row == _hero.Y && col == _hero.X)
                    {
                        Console.Write(_hero.Symbol);
                    }
                    else if (row == _treasure.Y && col == _treasure.X)
                    {
                        Console.Write("T");
                    }
                    else
                    {
                        Console.Write(EmptyCharacter);
                    }
                }

                // right wall border
                Console.WriteLine(WallCharacter);
            }

            // bottom wall border
            Console.WriteLine(new string(WallCharacter, Width + 2));
        }

        private void Move()
        {

            Console.Write(_hero.Name + ", move [WASD]: ");
            string move = Console.ReadKey().KeyChar.ToString().ToUpper();

            switch (move[0])
            {
                case 'W':
                {
                    _hero.MoveUp();
                    break;
                }
                case 'A':
                {
                    _hero.MoveLeft();
                    break;
                }
                case 'S':
                {
                    _hero.MoveDown();
                    break;
                }
                case 'D':
                {
                    _hero.MoveRight();
                    break;
                }
                default:
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    break;
                }
            }

            if (_hero.X < 0 || _hero.X >= Width
                    || _hero.Y < 0 || _hero.Y >= Width)
            {
                Console.WriteLine(_hero.Name + " touched lava! You lose.");
                _isOver = true;
            }
            else if (_hero.X == _treasure.X && _hero.Y == _treasure.Y)
            {
                Console.WriteLine(_hero.Name + " found the treasure! You win.");
                _isOver = true;
            }
        }
    }

}
