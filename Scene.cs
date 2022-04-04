﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;z

namespace SpaceGame
{
    class Scene
    {
        List <GameObject> _armyOfEnemies;
        List <GameObject> _ground;
        List <GameObject> _playerProgectile;
        GameSettings _gameSettings;
        
        GameObject _playerShip;

        #region Singleton
        private static Scene _scene;
        private Scene()
        {

        }

        private Scene(GameSettings gameSettings)
        {
            _gameSettings = gameSettings;
            _armyOfEnemies = new EnemyShipFactory(_gameSettings).GetArmyOfEnemyShips();
            _ground = 
            _playerShip = 
            _playerProgectile =
        }

        public static Scene GetScene(GameSettings gameSettings)
        {
            if(_scene == null)
            {
                _scene = new Scene(gameSettings);
            }
            return _scene;
        }
        #rndregion
    }
}
