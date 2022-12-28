using Sea_War.Library.Enum;
using Sea_War.Library.Interface;
using System;
using System.Windows.Forms;

namespace Sea_War.Library.Concrete
{
    public class Game : IGame
    {
        public bool IsGamePlaying { get; private set; }

        public TimeSpan PassingTime {get; set; }

        public void MoveShip(Direction direction)
        {
            throw new NotImplementedException();
        }

        public void Shoot()
        {
            throw new NotImplementedException();
        }

        public void StartGame()
        {
            if (IsGamePlaying) return;
            MessageBox.Show("Game Started");

            IsGamePlaying = true;
         }

        private void FinishGame()
        {
            if (!IsGamePlaying) return;
            IsGamePlaying = false;
        }
    }
}
