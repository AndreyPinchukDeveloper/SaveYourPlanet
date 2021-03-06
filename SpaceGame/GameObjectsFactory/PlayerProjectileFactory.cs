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
            GameObjectPlace projectilePlace = new GameObjectPlace()
            {
                XCoordinate = objectPlace.XCoordinate,
                YCoordinate = objectPlace.YCoordinate - 1
            };

            GameObject projectile = new Projectile() 
            { 
                Figure = GameSettings.PlayerProgectile, 
                GameObjectPlace = projectilePlace, 
                GameObjectType = GameObjectType.Projectile 
            };
            return projectile;
        }
    }
}
