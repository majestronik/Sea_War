
using Sea_War.Library.Concrete;
using Sea_War.Library.Enum;
namespace Sea_War
{
    public partial class GameForm : Form
    {
        private readonly Game _game = new Game();
        public GameForm()
        {
            InitializeComponent();
            _game.PassingTimeHasChanged+= Game_PassingTimeHasChanged;
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    _game.StartGame();
                    break;

                case Keys.Right:
                    _game.MoveShip(Direction.Right);
                    break;

                case Keys.Left:
                    _game.MoveShip(Direction.Left);
                    break;

                case Keys.Space:
                    _game.Shoot();
                    break;
            }
        }

        private void Game_PassingTimeHasChanged(object sender ,EventArgs e)
        {
            lblTime.Text = $"{_game.PassingTime.Minutes}:{_game.PassingTime.Seconds.ToString("D2")}";
        }
    }
}