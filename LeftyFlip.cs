using System;
using OpenTabletDriver.Plugin.Attributes;
using OpenTabletDriver.Plugin.Tablet;
using System.Numerics;
using OpenTabletDriver.Plugin;
using OpenTabletDriver.Plugin.Logging;

namespace LeftyFlip
{
    public class LeftyFlipFilter : IFilter
    {
        public Matrix3x2 rotationMatrix = Matrix3x2.CreateRotation((float)Math.PI)
        * Matrix3x2.CreateTranslation(Info.Driver.TabletIdentifier.MaxX, Info.Driver.TabletIdentifier.MaxY);
        
        public Vector2 Filter(Vector2 point)
        {
            return Vector2.Transform(point,this.rotationMatrix);
        }
        public FilterStage FilterStage => FilterStage.PreTranspose;
    }
}
