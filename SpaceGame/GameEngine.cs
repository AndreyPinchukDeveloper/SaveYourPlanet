using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpaceGame
{
    class GameEngine
    {
        private bool _isNotOver;
        private static GameEngine _gameEngine;
        private SceneRender _sceneRender;
        private GameSettings _gameSettings;
        private Scene _scene;
       
        #region Singleton
        

        private GameEngine()
        {

        }

        public static GameEngine GetGameEngine(GameSettings gameSettings)//return GameEngine
        {
            if (_gameEngine == null)
            {
                _gameEngine = new GameEngine(gameSettings);
            }
            return _gameEngine;
        }

        private GameEngine(GameSettings gameSettings)
        {
            _gameSettings = gameSettings;
            _isNotOver = true;
            _scene = Scene.GetScene(gameSettings);
            _sceneRender = new SceneRender(gameSettings);
        }
        #endregion

        public void Run()
        {
            int enemyArmyCounter = 0;
            int playerProjectileCounter = 0;

            do
            {
                _sceneRender.Render(_scene);
                Thread.Sleep(_gameSettings.SpeedOfFrame);
                _sceneRender.ClearScreen();

                if (enemyArmyCounter==_gameSettings.EnemySpeed)
                {
                    CalculateEnemiesMove();
                    enemyArmyCounter = 0;
                }
                enemyArmyCounter++;

                if (playerProjectileCounter == _gameSettings.PlayerProgectileSpeed)
                {
                    CalculateProjectileMove();
                    playerProjectileCounter = 0;
                }
                playerProjectileCounter++;

            } while (_isNotOver);
            Console.ForegroundColor = ConsoleColor.Red;
            _sceneRender.GameOver();
        }

        public void CalculateMovePlayerLeft()
        {
            if (_scene.playerShip.GameObjectPlace.XCoordinate > 1)
            {
                _scene.playerShip.GameObjectPlace.XCoordinate--;
            }
        }

        public void CalculateMovePlayerRight()
        {
            if (_scene.playerShip.GameObjectPlace.XCoordinate < _gameSettings.ConsoleWidth)
            {
                _scene.playerShip.GameObjectPlace.XCoordinate++;
            }
        }

        public void CalculateEnemiesMove()
        {
            for (int i = 0; i < _scene.armyOfEnemies.Count; i++)
            {
                GameObject enemyArmy = _scene.armyOfEnemies[i];
                enemyArmy.GameObjectPlace.YCoordinate++;

                if (enemyArmy.GameObjectPlace.YCoordinate == _scene.playerShip.GameObjectPlace.YCoordinate)
                {
                    _isNotOver = false;
                }
            }
        }

        public void Shot()
        {
            PlayerProjectileFactory projectileFactory = new PlayerProjectileFactory(_gameSettings);
            GameObject projectile = projectileFactory.GetGameObject(_scene.playerShip.GameObjectPlace);

            _scene.playerProjectile.Add(projectile);
            Console.Beep(1000, 200);
        }

        public void CalculateProjectileMove()
        {
            if (_scene.playerProjectile.Count == 0)
            {
                return;
            }
            for (int i = 0; i < _scene.playerProjectile.Count; i++)
            {
                GameObject projectile = _scene.playerProjectile[i];
                if (projectile.GameObjectPlace.YCoordinate == 1)
                {
                    _scene.playerProjectile.RemoveAt(i);
                }
                projectile.GameObjectPlace.YCoordinate--;

                for (int y = 0; y < _scene.armyOfEnemies.Count; y++)
                {
                    GameObject enemyShip = _scene.armyOfEnemies[y];
                    if (projectile.GameObjectPlace.Equals(enemyShip.GameObjectPlace))
                    {
                        _scene.armyOfEnemies.RemoveAt(y);
                        _scene.playerProjectile.RemoveAt(i);
                        break;
                    }
                }
            }
        }
    }
}
