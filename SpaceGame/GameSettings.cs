using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class GameSettings
    {
        public int ConsoleWidth { get; set; } = 80;
        public int ConsoleHeight { get; set; } = 30;

        public int CountOfEnemyRows { get; set; } = 2;
        public int CountOfEnemyColls { get; set; } = 60;

        public int EnemyXCoordinateStart { get; set; } = 10;
        public int EnemyYCoordinateStart { get; set; } = 2;
        public char EnemyShip { get; set; } = 'O';
        public int EnemySpeed { get; set; } = 20;

        public int PlayerXCoordinateStart { get; set; } = 40;
        public int PlayerYCoordinateStart { get; set; } = 19;
        public char PlayerShip { get; set; } = 'W';

        public int GroundXCoordinateStart { get; set; } = 1;
        public int GroundYCoordinateStart { get; set; } = 20;
        public char Ground { get; set; } = '-';
        public int CountOfGroundRows { get; set; } = 1;
        public int CountOfGroundColls { get; set; } = 80;

        public char PlayerProgectile { get; set; } = '^';
        public int PlayerProgectileSpeed { get; set; } = 5;

        public int SpeedOfFrame { get; set; } = 100;
    }
}
