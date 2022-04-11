using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class PlayerShipFactory : GameObjectsFactory
    {
        public PlayerShipFactory(GameSettings gameSettings) : base(gameSettings)
        {

        }

        public override GameObject GetGameObject(GameObjectPlace objectPlace)
        {
            GameObject playerObject = new Player() 
            { 
                Figure = GameSettings.PlayerShip, 
                GameObjectPlace = objectPlace, 
                GameObjectType = GameObjectType.Player 
            };
            return playerObject;
        }

        public GameObject GetGameObject()
        {

            GameObjectPlace place = new GameObjectPlace() 
            { 
                XCoordinate = GameSettings.PlayerXCoordinateStart, 
                YCoordinate = GameSettings.PlayerYCoordinateStart 
            };
            GameObject gameObject = GetGameObject(place);
            return gameObject;
        }
    }
}
