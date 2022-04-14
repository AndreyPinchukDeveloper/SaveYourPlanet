﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class PlayerController
    {
        public event EventHandler OnAPressed;
        public event EventHandler OnDPressed;
        public event EventHandler OnSpacePressed;

        public void Move()
        {
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key.Equals(ConsoleKey.A))
                {
                    OnAPressed?.Invoke(this, new EventArgs());
                }
                else if (key.Key.Equals(ConsoleKey.D))
                {
                    OnDPressed?.Invoke(this, new EventArgs());
                }
                else if (key.Key.Equals(ConsoleKey.Space))
                {
                    OnDPressed?.Invoke(this, new EventArgs());
                }
                else
                {

                }
            }
        }
    }
}
