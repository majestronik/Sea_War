using Sea_War.Library.Enum;
using System;

namespace Sea_War.Library.Interface
{
    internal interface IGame
    {
        bool IsGamePlaying { get; }
        TimeSpan PassingTime { get; }
        
        void StartGame();
        void Shoot();
        void MoveShip(Direction direction);
    }
}
