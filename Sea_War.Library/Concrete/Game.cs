using Sea_War.Library.Enum;
using Sea_War.Library.Interface;
using System;
using System.Windows.Forms;

namespace Sea_War.Library.Concrete
{
    public class Game : IGame
    {

        #region Statements
        public bool IsGamePlaying { get; private set; }
        public event EventHandler PassingTimeHasChanged;

        #endregion

        #region Features
        private TimeSpan _passingTime;
        public TimeSpan PassingTime {
            get => _passingTime;
            private set
            {
                _passingTime = value;

                PassingTimeHasChanged?.Invoke(this, EventArgs.Empty);
            } 
        }
        public Timer myTimer = new Timer();

        #endregion

        #region Methods

        public Game()
        {
            myTimer.Interval = 1000;
            myTimer.Tick += MyTimer_Tick;
        }

        public void StartGame()
        {
            if (IsGamePlaying) return;
            MessageBox.Show("Game Started");

            myTimer.Start();

            IsGamePlaying = true;
        }

        private void FinishGame()
        {
            if (!IsGamePlaying) return;
            IsGamePlaying = false;
            myTimer.Stop();
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            PassingTime += TimeSpan.FromSeconds(1);
        }

        public void MoveShip(Direction direction)
        {
            throw new NotImplementedException();
        }

        public void Shoot()
        {
            throw new NotImplementedException();
        }

        
        #endregion
    }
}
