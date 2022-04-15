using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class SceneRender
    {
        int _screenWidth;
        int _screenHeight;
        char[,] _screenMatrix;

        public SceneRender(GameSettings gameSettings)
        {
            _screenWidth = gameSettings.ConsoleWidth;
            _screenHeight = gameSettings.ConsoleHeight;
            _screenMatrix = new char[gameSettings.ConsoleHeight, gameSettings.ConsoleWidth];
            Console.WindowHeight = gameSettings.ConsoleHeight;
            Console.WindowWidth = gameSettings.ConsoleWidth;
            SetCursorPosition();
        }

        public void Render(Scene scene)
        {
            ClearScreen();
            SetCursorPosition();
            AddListForRendering(scene.armyOfEnemies);
            AddListForRendering(scene.ground);
            AddListForRendering(scene.playerProjectile);
            AddGameObjectForRendering(scene.playerShip);
              
            StringBuilder stringBuilder = new StringBuilder();

            for (int y = 0; y < _screenHeight; y++)
            {
                for (int x = 0; x < _screenWidth; x++)
                {
                    stringBuilder.Append(_screenMatrix[y, x]);
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

            if (y < _screenMatrix.GetLength(0) && x < _screenMatrix.GetLength(1))
            {
                _screenMatrix[y, x] = gameObject.Figure;
             }
            else
            {
                //_screenMatrix[y, x] = ' ';
            }
        }

        public void AddListForRendering(List<GameObject> gameObjects)
        {
            foreach (GameObject gameObject in gameObjects)
            {
                AddGameObjectForRendering(gameObject);
            }
        }

        public void SetCursorPosition()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 0);
        }

        public void ClearScreen()
        {
            for (int y = 0; y < _screenHeight; y++)
            {
                for (int x = 0; x < _screenWidth; x++)
                {
                    _screenMatrix[y, x] = ' ';
                }
            }
            SetCursorPosition();
        }

        public void GameOver()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Game over !");
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
