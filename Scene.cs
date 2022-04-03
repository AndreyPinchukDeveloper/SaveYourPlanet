using System;
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
        
        GameObject _playerShip;

        #region Singleton
        private static Scene _scene;
        private Scene()
        {

        }

        public static Scene GetScene()
        {
            if(_scene == null)
            {
                
            }
            return _scene;
        }
        #rndregion
    }
}
