using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;z

namespace SpaceGame
{
    class SceneRender
    {
        int _screenWidth;
        int _screenHeight;
        char[,] _screenMatrix;

        public SceneRender(GameSettings game gameSettings)
        {
            _screenWidth = gameSettings.ConsoleWidth + 1;
            _screenHeight = gameSettings.ConsoleHeight + 1;
            _screenMatrix = new char [gameSettings.ConsoleWidth, gameSettings.ConsoleHeight];
            Console.WindowHeight = gameSettings.ConsoleHeight;
            Console.BufferWidth = gameSettings.ConsoleWidth;
            SetCursorPosition();
        }

        public void Render(Scene scene)
        {
            SetCursorPosition();
            AddListForRendering(scene.armyOfEnemies);
            AddListForRendering(scene.ground);
            AddListForRendering(scene.playerProjectile);
            AddListForRendering(scene.playerShip);
            StringBuilder StringBuilder = new StringBuilder();

            for(int y = 0; y < _screenHeight; y++)
            {
                for(int x = 0; x < _screenWidth; y++)
                {
                    stringBuilder.Append(_screenMatrix[y,x]);
                }
                stringBuilder.Append(Environment.NewLine);
            }

            Console.WriteLine(stringBuilder.ToString());
            SetCursorPosition();
        }

        public void AddGameObjectForRendering(GameObject gameObject)//check here
        {
            int x = gameObject.GameObjectPlace.XCoordinate;
            int y = gameObject.GameObjectPlace.YCoordinate;

            if(x < _screenMatrix.GetLength(0) && y < _screenMatrix.GetLength(1))
            {
                _screenMatrix[x,y] = gameObject.Figure;
            }
            else
            {
                _screenMatrix[x,y] = ' ';
            }
        }

        public void AddListForRendering(List<GameObject> gameObjects)
        {
            foreach(GameObject gameObject in gameObjects)
            {
                AddGameObjectForRendering(gameObject);
            }
        }

        public void SetCursorPosition()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition (0,0);
        }

    }
}
