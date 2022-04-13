using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SpaceGame
{
    class Program
    {
        static GameEngine gameEngine;
        static GameSettings gameSettings;
        static PlayerController playerController;

        static void Main(string[] args)
        {
            Initialize();
            gameEngine.Run();
        }

        public static void Initialize()
        {
            gameSettings = new GameSettings();
            gameEngine = GameEngine.GetGameEngine(gameSettings);
            playerController = new PlayerController();

            playerController.OnAPressed += (obj, arg) => gameEngine.CalculateMovePlayerLeft();
            playerController.OnDPressed += (obj, arg) => gameEngine.CalculateMovePlayerRight();
            Thread playerControllerThread = new Thread(playerController.Move);
            playerControllerThread.Start();

            Thread.CurrentThread.Priority = ThreadPriority.AboveNormal;
        }
    }
}
