using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class EnemyShipFactory : GameObjectsFactory
    {
        public EnemyShipFactory(GameSettings gameSettings) : base(gameSettings)
        {

        }

        public override GameObject GetGameObject(GameObjectPlace objectPlace)
        {
            GameObject enemyShip = new EnemyShip()
            {
                Figure = GameSettings.EnemyShip,
                GameObjectPlace = objectPlace,
                GameObjectType = GameObjectType.EnemyShip
            };
            return enemyShip;
        }

        public List<GameObject> GetArmyOfEnemyShips()
        {
            List<GameObject> army = new List<GameObject>();
            int startX = GameSettings.EnemyXCoordinateStart;
            int startY = GameSettings.EnemyYCoordinateStart;
            for (int y = 0; y < GameSettings.CountOfEnemyRows; y++)
            {
                for (int x = 0; x < GameSettings.CountOfEnemyColls; x++)
                {
                    GameObjectPlace objectPlace = new GameObjectPlace() { XCoordinate = startX + x, YCoordinate = startY + y };
                    GameObject enemyShip = GetGameObject(objectPlace);
                    army.Add(enemyShip);
                }
            }
            return army;
        }
    }
}
