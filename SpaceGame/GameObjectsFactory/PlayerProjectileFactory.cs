using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class PlayerProjectileFactory : GameObjectsFactory
    {
        public PlayerProjectileFactory(GameSettings gameSettings) : base(gameSettings)
        {

        }

        public override GameObject GetGameObject(GameObjectPlace objectPlace)
        {
            GameObject projectile = new Projectile() 
            { 
                Figure = GameSettings.PlayerProgectile, 
                GameObjectPlace = objectPlace, 
                GameObjectType = GameObjectType.Projectile 
            };
            return projectile;
        }
    }
}
