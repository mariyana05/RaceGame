namespace Race
{
    public partial class RaceGame : Form
    {
        private Label[] rightHandRoadMarkingsPanelGame = new Label[5];
        private Label[] leftHandRoadMarkingsPanelGame = new Label[5];
        private Label[] rightHandRoadMarkingsMenu = new Label[5];
        private Label[] leftHandRoadMarkingsMenu = new Label[5];
        private Random r = new Random();
        private int score;
        private int coins;
        private int carSpeed;
        public RaceGame()
        {
            InitializeComponent();
        }
        private void timerRoad_Tick(object sender, EventArgs e)
        {
            labelScore.Text = "Score: " + score / 10;
            MoveLanes();
            MoveCoins();
            CoinsCollect();
        }

        private void MoveLanes()
        {
            for (int i = 0; i < rightHandRoadMarkingsPanelGame.Length; ++i)
            {
                rightHandRoadMarkingsPanelGame[i].Top += carSpeed;
                if (rightHandRoadMarkingsPanelGame[i].Top >= Height)
                {
                    rightHandRoadMarkingsPanelGame[i].Top = -rightHandRoadMarkingsPanelGame[i].Height;
                }
                if (carSpeed != 0)
                    score++;
            }
            for (int i = 0; i < leftHandRoadMarkingsPanelGame.Length; ++i)
            {
                leftHandRoadMarkingsPanelGame[i].Top += carSpeed;
                if (leftHandRoadMarkingsPanelGame[i].Top >= Height)
                    leftHandRoadMarkingsPanelGame[i].Top = -leftHandRoadMarkingsPanelGame[i].Height;
            }
        }

        private void MoveCoins()
        {
            Coin1.Top += carSpeed;
            if (Coin1.Top > Height)
            {
                Coin1.Top = -Coin1.Height;
                Coin1.Left = r.Next(0, Width - Coin1.Width);
            }
            Coin2.Top += carSpeed;
            if (Coin2.Top > Height)
            {
                Coin2.Top = -Coin2.Height;
                Coin2.Left = r.Next(0, Width - Coin2.Width);
            }
            Coin3.Top += carSpeed;
            if (Coin3.Top > Height)
            {
                Coin3.Top = -Coin3.Height;
                Coin3.Left = r.Next(0, Width - Coin3.Width);
            }
        }

        private void CoinsCollect()
        {
            if (mainCar.Bounds.IntersectsWith(Coin1.Bounds))
            {
                coins++;
                labelCoins.Text = "Coins: " + coins;
                Coin1.Top = -Coin1.Height;
                Coin1.Left = r.Next(0, 120);
            }
            if (mainCar.Bounds.IntersectsWith(Coin2.Bounds))
            {
                coins++;
                labelCoins.Text = "Coins: " + coins;
                Coin2.Top = -Coin2.Height;
                Coin2.Left = r.Next(120, 240);
            }
            if (mainCar.Bounds.IntersectsWith(Coin3.Bounds))
            {
                coins++;
                labelCoins.Text = "Coins: " + coins;
                Coin3.Top = -Coin3.Height;
                Coin3.Left = r.Next(240, 300);
            }
        }

        private void RaceGame_Load(object sender, EventArgs e)
        {
            rightHandRoadMarkingsPanelGame[0] = LaneOne1;
            rightHandRoadMarkingsPanelGame[1] = LaneOne2;
            rightHandRoadMarkingsPanelGame[2] = LaneOne3;
            rightHandRoadMarkingsPanelGame[3] = LaneOne4;
            rightHandRoadMarkingsPanelGame[4] = LaneOne5;

            leftHandRoadMarkingsPanelGame[0] = LaneTwo1;
            leftHandRoadMarkingsPanelGame[1] = LaneTwo2;
            leftHandRoadMarkingsPanelGame[2] = LaneTwo3;
            leftHandRoadMarkingsPanelGame[3] = LaneTwo4;
            leftHandRoadMarkingsPanelGame[4] = LaneTwo5;

            rightHandRoadMarkingsMenu[0] = menuOneLane1;
            rightHandRoadMarkingsMenu[1] = menuOneLane2;
            rightHandRoadMarkingsMenu[2] = menuOneLane3;
            rightHandRoadMarkingsMenu[3] = menuOneLane4;
            rightHandRoadMarkingsMenu[4] = MenuOneLane5;

            leftHandRoadMarkingsMenu[0] = menuTwoLane1;
            leftHandRoadMarkingsMenu[1] = menuTwoLane2;
            leftHandRoadMarkingsMenu[2] = menuTwoLane3;
            leftHandRoadMarkingsMenu[3] = menuTwoLane4;
            leftHandRoadMarkingsMenu[4] = menuTwoLane5;

            timerRoad.Stop();
            timerTowardCars.Stop();
            panelMenu.Show();
        }

        private void RaceGame_KeyDown(object sender, KeyEventArgs e)
        {
            LeftAndRightKeyPress(e);
            UpKeyPress(e);
            DownKeyPress(e);
            EscapeKeyPress(e);
        }
        private void LeftAndRightKeyPress(KeyEventArgs e)
        {
            if (carSpeed != 0)
            {
                if (e.KeyCode == Keys.Right)
                {

                    if (mainCar.Right < 500)
                        mainCar.Left += 9;
                }
                if (e.KeyCode == Keys.Left)
                {
                    if (mainCar.Left > 0)
                        mainCar.Left -= 9;
                }
            }
        }
        private void UpKeyPress(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (carSpeed < 21)
                    carSpeed++;
            }
        }
        private void DownKeyPress(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (carSpeed > 0)
                    carSpeed--;
            }
        }
        private void EscapeKeyPress(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                timerRoad.Enabled = false;
                timerTowardCars.Enabled = false;
                panelPause.Show();
            }
        }

        private void timerTowardCars_Tick(object sender, EventArgs e)
        {
            GenerateNewCar();
            CheckGameEnd();
        }

        private void CheckGameEnd()
        {
            if (mainCar.Bounds.IntersectsWith(towardCar1.Bounds))
                GameOver();
            if (mainCar.Bounds.IntersectsWith(towardCar2.Bounds))
                GameOver();
            if (mainCar.Bounds.IntersectsWith(towardCar3.Bounds))
                GameOver();
        }

        private void GenerateNewCar()
        {
            towardCar1.Top += carSpeed + 4;
            if (towardCar1.Top > Height)
            {
                towardCar1.Top = -towardCar1.Height;
                towardCar1.Left = r.Next(0, Width - towardCar1.Width);
            }

            towardCar2.Top += carSpeed + 2;
            if (towardCar2.Top > Height)
            {
                towardCar2.Top = -towardCar2.Height;
                towardCar2.Left = r.Next(0, Width - towardCar2.Width);
            }

            towardCar3.Top += carSpeed + 3;
            if (towardCar3.Top > Height)
            {
                towardCar3.Top = -towardCar3.Height;
                towardCar3.Left = r.Next(0, Width - towardCar3.Width);
            }
        }

        private void GameOver()
        {
            timerRoad.Stop();
            timerTowardCars.Stop();
            if (coins < 15)
            {
                DialogResult dd = MessageBox.Show("Game Over!", "Приехали!");
                panelPause.Show();
                panelMenu.Show();
            }
            else
            {
                DialogResult dr = MessageBox.Show("Продолжить? (-15 coins)", "Приехали!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                    Restart();
                else if (dr == DialogResult.No)
                {
                    panelPause.Show();
                    panelMenu.Show();
                }
            }
        }

        private void Restart()
        {
            coins -= 15;
            labelCoins.Text = "Coins: " + coins;
            carSpeed = 2;
            timerRoad.Start();
            timerTowardCars.Start();
            towardCar1.Top = -towardCar1.Height;
            towardCar1.Left = r.Next(0, Width - towardCar1.Width);
            towardCar2.Top = -towardCar2.Height;
            towardCar2.Left = r.Next(0, Width - towardCar2.Width);
            towardCar3.Top = -towardCar3.Height;
            towardCar3.Left = r.Next(0, Width - towardCar3.Width);
        }

        private void timerMenu_Tick(object sender, EventArgs e)
        {
            MenuLinesMove();
            MenuCarGenerate();
        }

        private void MenuCarGenerate()
        {
            carMenu1.Top += carSpeed + 5;
            if (carMenu1.Top > Height)
            {

                carMenu1.Top = -carMenu1.Height;
                carMenu1.Left = r.Next(0, Width - carMenu1.Width);
            }
            carMenu2.Top += carSpeed + 3;
            if (carMenu2.Top > Height)
            {
                carMenu2.Top = -carMenu2.Height;
                carMenu2.Left = r.Next(0, Width - carMenu2.Width);
            }
            carMenu3.Top += carSpeed + 4;
            if (carMenu3.Top > Height)
            {
                carMenu3.Top = -carMenu3.Height;
                carMenu3.Left = r.Next(0, Width - carMenu3.Width);
            }
        }

        private void MenuLinesMove()
        {
            for (int i = 0; i < rightHandRoadMarkingsMenu.Length; ++i)
            {
                rightHandRoadMarkingsMenu[i].Top += carSpeed;
                if (rightHandRoadMarkingsMenu[i].Top >= Height)
                {
                    rightHandRoadMarkingsMenu[i].Top = -rightHandRoadMarkingsMenu[i].Height;
                }
            }
            for (int i = 0; i < leftHandRoadMarkingsMenu.Length; ++i)
            {
                leftHandRoadMarkingsMenu[i].Top += carSpeed;
                if (leftHandRoadMarkingsMenu[i].Top >= Height)
                {
                    leftHandRoadMarkingsMenu[i].Top = -leftHandRoadMarkingsMenu[i].Height;

                }
            }
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            timerRoad.Enabled = false;
            timerTowardCars.Enabled = false;
            panelPause.Show();
        }

        private void buttonResume_Click(object sender, EventArgs e)
        {
            timerRoad.Enabled = true;
            timerTowardCars.Enabled = true;
            panelPause.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            panelMenu.Show();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            StartGame();
            panelGame.Show();
            panelMenu.Hide();

        }
        private void StartGame()
        {
            score = 0;
            coins = 0;
            carSpeed = 2;
            timerRoad.Start();
            timerTowardCars.Start();
            timerMenu.Start();
            towardCar1.Top = -towardCar1.Height;
            towardCar1.Left = r.Next(0, Width - towardCar1.Width);
            towardCar2.Top = -towardCar2.Height;
            towardCar2.Left = r.Next(0, Width - towardCar2.Width);
            towardCar3.Top = -towardCar3.Height;
            towardCar3.Left = r.Next(0, Width - towardCar3.Width);

            panelMenu.Hide();
            panelPause.Hide();
            panelGame.Show();
            buttonPause.Visible = true;
        }

        private void buttonMenuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            var baseDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            Help.ShowHelp(this, $"{baseDirectory}\\help.chm", HelpNavigator.TableOfContents);
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


