using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;400
using System.Windows.Forms;z

namespace SpaceGame
{
    class Scene
    {
        public List <GameObject> armyOfEnemies;
        public List <GameObject> ground;
        public List <GameObject> playerProjectile;
        GameSettings _gameSettings;
        
        public GameObject playerShip;

        #region Singleton
        private static Scene _scene;
        private Scene()
        {

        }

        private Scene(GameSettings gameSettings)
        {
            _gameSettings = gameSettings;
            armyOfEnemies = new EnemyShipFactory(_gameSettings).GetArmyOfEnemyShips();
            ground = new GroundFactory(ground).GetGround();
            playerShip = new PlayerShipFactory(playerShip).GetGameObject();
        }

        public static Scene GetScene(GameSettings gameSettings)
        {
            if(_scene == null)
            {
                _scene = new Scene(gameSettings);
            }
            return _scene;
        }
        #endregion
    }
}
