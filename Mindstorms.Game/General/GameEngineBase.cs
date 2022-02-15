using Mindstorms.Core;
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
                    brick.DrawString(LCDCommand.HorizontalCenter - 40, LCDCommand.VerticalCenter, message);
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
            GameFrame.Upload(brick);
            brick.ChangeTopLine(State.Disable);
        }

        private void Pause()
        {
            brick.DrawString(LCDCommand.HorizontalCenter - 30, LCDCommand.VerticalCenter, "Paused", Color.Black, FontType.Normal);
            brick.DrawString(20, LCDCommand.VerticalCenter + 30, "Press down/up key", Color.Black, FontType.Normal);
            brick.UpdateScreen();

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
