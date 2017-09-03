﻿namespace Casting.RayCasting.Interfaces
{
    public interface ICastCondition
    {
        bool IsMet { get; }
        void ObstacleCrossed(double distance);

        void Reset();
    }
}