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
        static MusicController musicController;

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
            musicController = new MusicController();

            Thread playMusic = new Thread(musicController.PlayBackgroundMusic);
            playMusic.Start();

            playerController.OnAPressed += (obj, arg) => gameEngine.CalculateMovePlayerLeft();
            playerController.OnDPressed += (obj, arg) => gameEngine.CalculateMovePlayerRight();
            playerController.OnSpacePressed += (obj, arg) => gameEngine.Shot();
            Thread playerControllerThread = new Thread(playerController.Move);
            playerControllerThread.Start();

            Thread.CurrentThread.Priority = ThreadPriority.AboveNormal;
        }
    }
}
