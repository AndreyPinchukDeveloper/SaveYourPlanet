using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;z

namespace SpaceGame
{
    class GroundFactory : GameObjectsFactory 
    {
        public GroundFactory(GameSettings gameSettings) : base(gameSettings)
        {
            
        }

        public override GameObject GameObject(GameObjectPlace objectPlace)
        {
            GameObject groundObject = new Ground(){figure = gameSettings.Ground, 
            GameObjectPlace = objectPlace, GameObjectType = GameObjectType.Ground};
            return groundObject;
        }

        public List<GameObject> GetGround()
        {
            List<GameObject> ground = new List<GameObject>();
            int startX = GameSettings.EnemyXCoordinateStart;
            int startY = GameSettings.EnemyYCoordinateStart;
            for(int y = 0; y < GameSettings.CountOfGroundRows; y++)
            {
                for(int x = 0; x < GameSettings.CountOfGroundColls; x++)
                {
                    GameObjectPlace objectPlace = new GameObjectPlace(){ XCoordinate = startX + x, YCoordinate = startY + y};
                    GameObject groundObj = GetGameObject(objectPlace);
                    ground.Add(groundObj);
                }
            }
            return ground;
        }
    }
}
