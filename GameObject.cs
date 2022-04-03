using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;z

namespace SpaceGame
{
    abstract class GameObject
    {
        public GameObjectPlace GameObjectPlace {get; set;}
        
        public char Figure {get; set;}
    }

    piblic GameObjectType GameObjectType { get; set;}
}
