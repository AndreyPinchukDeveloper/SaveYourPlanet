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

        public override GameObject GetGameObject(GameObjectPlace objectPlace)
        {
            GameObject projectile = new Projectile(){figure = gameSettings.PlayerProgectile, GameObjectPlace = objectPlace, GameObjectType = GameObjectType.Projectile};
            return projectile;
        }

        public GameObject GetGameObject()
        {

            GameObjectPlace place = new GameObjectPlace() { XCoordinate = GameSettings.PlayerXStartCoordinate, YCoordinate = GameSettings.PlayerYStartCoordinate };
            GameObject gameObject = GetGameObject(place);
            return gameObject;
        }
    }
}
