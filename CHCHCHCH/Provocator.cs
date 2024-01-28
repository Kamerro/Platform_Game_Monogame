using System;

namespace CHCHCHCH
{
    internal class Provocator:Base2D
    {
        public override void CalculatePosition()
        {
            this.Position.X += Random.Shared.NextInt64(-5, 6);
            this.Position.Y += Random.Shared.NextInt64(-5, 6);
        }
    }
}