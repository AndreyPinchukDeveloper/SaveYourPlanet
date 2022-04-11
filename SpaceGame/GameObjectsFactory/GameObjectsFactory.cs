﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    abstract class GameObjectsFactory
    {
        public GameSettings GameSettings { get; set; }
        public abstract GameObject GetGameObject(GameObjectPlace objectPlace);

        public GameObjectsFactory(GameSettings gameSettings)
        {
            GameSettings = gameSettings;
        }
    }
}
