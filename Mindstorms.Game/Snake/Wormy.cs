using Mindstorms.Core.Commands.LCD;
using Mindstorms.Core.Drawing;
using Mindstorms.Core.EV3;
using Mindstorms.Game.General;
using System.Collections.Generic;

namespace Mindstorms.Game.Snake
{
    public class Wormy : Directable
    {
        private readonly List<EV3Circle> bodyParts = new List<EV3Circle>();
        private readonly MovingDifferenceProvider movingDifferenceProvider = new MovingDifferenceProvider();

        public Wormy()
        {
            for (byte i = 0; i < Constants.NumberOfBodyParts; i++)
            {
                bodyParts.Add(new EV3Circle((byte)(20 + ((int)Direction * i * MovingDifferenceProvider.PixelsToMove)), LCDCommand.VerticalCenter, Constants.WormBodyRadius, false));
            }
        }

        public void Draw(Brick brick)
        {
            for (int i = 0; i < bodyParts.Count; i++)
            {
                brick.Draw(bodyParts[i]);
            }
        }

        public bool MoveForward()
        {
            bodyParts.RemoveAt(0);
            var head = GetHead();
            var movingModifier = movingDifferenceProvider.GetMovingDifference(Direction);
            bodyParts.Add(new EV3Circle((byte)(head.Center.X + movingModifier.DeltaX), (byte)(head.Center.Y + movingModifier.DeltaY), Constants.WormBodyRadius, false));
            return LCDCommand.IsPointInScreen(head.Center) && !HasCollision();
        }

        public bool CanConsumeFood(EV3Circle foodLocation)
        {
            for (int i = 0; i < bodyParts.Count; i++)
            {
                if (bodyParts[i].IsColliding(foodLocation))
                {
                    return true;
                }
            }
            return false;
        }

        public void Grow(int nutrition)
        {
            var count = nutrition / 5;
            var tail = GetTail();
            for (int i = 0; i < count; i++)
            {
                bodyParts.Insert(0, new EV3Circle(tail.Center.X, tail.Center.Y, Constants.WormBodyRadius, false));
            }
        }

        private bool HasCollision()
        {
            var headCenter = GetHead().Center;
            for (int i = 0; i < bodyParts.Count - 3; i++)
            {
                if (bodyParts[i].Center.GetDistance(headCenter) < Constants.WormBodyRadius)
                {
                    return true;
                }
            }
            return false;
        }

        private EV3Circle GetHead()
        {
            return bodyParts[bodyParts.Count - 1];
        }

        private EV3Circle GetTail()
        {
            return bodyParts[0];
        }
    }
}
