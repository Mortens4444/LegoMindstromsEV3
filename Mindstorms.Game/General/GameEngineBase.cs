using Mindstorms.Core.Enums;
using Mindstorms.Core.EV3;
using Mindstorms.Core.Responses;
using System.Threading;

namespace Mindstorms.Game.General
{
    public abstract class GameEngineBase
    {
        protected Brick brick;
        protected bool inGame;
        protected string message;

        public GameEngineBase(Brick brick)
        {
            this.brick = brick;
            StartNewGame();
        }

        protected abstract void StartNewGame();
        
        protected abstract ButtonStates GameMoment();

        public void GameLoop()
        {
            Initialize();

            while (inGame)
            {
                brick.ClearScreen();

                HandleGameState(GameMoment());

                if (!inGame)
                {
                    brick.ShowOnMiddleOfScreen(message, FontType.Normal, 0);
                }

                brick.UpdateScreen();
                Thread.Sleep(inGame ? 30 : 3000);
            }

            Finish();
        }

        private void HandleGameState(ButtonStates buttonStates)
        {
            if (buttonStates.IsBackButtonPressed())
            {
                inGame = false;
            }
            if (buttonStates.IsCenterButtonPressed())
            {
                if (!inGame)
                {
                    StartNewGame();
                }
                else
                {
                    Pause();
                }
            }
        }

        private void Initialize()
        {
            GameFrame.UploadAndStart(brick);
            brick.ChangeTopLine(State.Disable);
        }

        private void Pause()
        {
            brick.ClearScreen();
            brick.ShowOnMiddleOfScreen("Paused", FontType.Big, 0);
            brick.ShowOnMiddleOfScreen("Press down/up key", FontType.Normal, 30);

            ButtonStates buttonStates;
            do
            {
                buttonStates = brick.GetButtonStates();
                Thread.Sleep(100);
            }
            while (!buttonStates.IsDownButtonPressed() && !buttonStates.IsUpButtonPressed());
        }

        private void Finish()
        {
            brick.ChangeTopLine(State.Enable);
            brick.StopApplication();
        }
    }
}
