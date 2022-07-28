using System;
using System.Collections.Generic;
using System.Text;

namespace Motion_Foca
{
    public interface IAxis
    {
        int AxisID { get; }
        decimal Factor { get; set; }
         int OriginDirection { get; set; }
        decimal PositionAfterHome { get; set; }
        decimal CurrentPosition { get; }
        decimal CurrentVelocity { get; }
        bool Inposition { get; }
        bool Emergency { get; }
        bool OriginPosition { get; }
        
        void MoveAbsolute(decimal Position, decimal Velocity);
        void MoveAbsolute(decimal Position, decimal Velocity, decimal Acc);
        void MoveAbsolute(decimal Position, decimal Velocity, decimal Acc, decimal Dec);
        void MoveRelative(decimal Distance, decimal Velocity);
        void MoveRelative(decimal Distance, decimal Velocity, decimal Acc);
        void MoveRelative(decimal Distance, decimal Velocity, decimal Acc, decimal Dec);
        void StopMove();
        void SearchOrigin();
        void SetPosition(decimal Position);
        void Jog(decimal Velocity, int Direction);


    }

    
}
