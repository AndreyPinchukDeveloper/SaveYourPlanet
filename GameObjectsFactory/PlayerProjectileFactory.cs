using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;z

namespace SpaceGame
{
    class PlayerProjectileFactory : GameObjectsFactory 
    {
        public PlayerProjectileFactory(GameSettings gameSettings) : base(gameSettings)
        {
            
        }

        public override GameObject GameObject(GameObjectPlace objectPlace)
        {
            GameObject projectile = new Projectile(){figure = gameSettings.PlayerProgectile, 
            GameObjectPlace = objectPlace, GameObjectType = GameObjectType.Progectile};
            return projectile;
        }

        public List<GameObject> GetArmyOfEnemyShips()
        {
            List<GameObject> army = new List<GameObject>();
            int startX = GameSettings.EnemyXCoordinateStart;
            int startY = GameSettings.EnemyYCoordinateStart;
            for(int y = 0; y < GameSettings.CountOfEnemyRows; y++)
            {
                for(int x = 0; x < GameSettings.CountOfEnemyColls; x++)
                {
                    GameObjectPlace objectPlace = new GameObjectPlace(){ XCoordinate = startX + x, YCoordinate = startY + y};
                    GameObject enemyShip = GetGameObject(objectPlace);
                    army.Add(enemyShip);
                }
            }
            return army;
        }
    }
}
