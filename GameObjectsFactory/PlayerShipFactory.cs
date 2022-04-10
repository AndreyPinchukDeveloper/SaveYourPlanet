using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;z

namespace SpaceGame
{
    class PlayerShipFactory : GameObjectsFactory 
    {
        public PlayerShipFactory(GameSettings gameSettings) : base(gameSettings)
        {
            
        }

        public override GameObject GetGameObject(GameObjectPlace objectPlace)
        {
            GameObject playerObject = new Player(){figure = gameSettings.PlayerShip, GameObjectPlace = objectPlace, GameObjectType = GameObjectType.PlayerShip};
            return playerObject;
        }

        public GameObject GetGameObject()
        {

            GameObjectPlace place = new GameObjectPlace() { XCoordinate = GameSettings.PlayerXStartCoordinate, YCoordinate = GameSettings.PlayerYStartCoordinate };
            GameObject gameObject = GetGameObject(place);
            return gameObject;
        }
    }
}
