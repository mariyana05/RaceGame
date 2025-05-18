namespace Race
{
    partial class RaceGame
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaceGame));
            timerRoad = new System.Windows.Forms.Timer(components);
            panelGame = new Panel();
            panelPause = new Panel();
            panelMenu = new Panel();
            resultsButton = new Button();
            nameTextBox = new TextBox();
            buttonHelp = new Button();
            buttonMenuExit = new Button();
            buttonStart = new Button();
            label3 = new Label();
            carMenu1 = new PictureBox();
            carMenu3 = new PictureBox();
            carMenu2 = new PictureBox();
            menuTwoLane5 = new Label();
            menuTwoLane4 = new Label();
            menuTwoLane3 = new Label();
            menuTwoLane2 = new Label();
            menuTwoLane1 = new Label();
            MenuOneLane5 = new Label();
            menuOneLane4 = new Label();
            menuOneLane3 = new Label();
            menuOneLane2 = new Label();
            menuOneLane1 = new Label();
            label12 = new Label();
            buttonExit = new Button();
            buttonResume = new Button();
            pictureFlag = new PictureBox();
            labelPause = new Label();
            labelScore = new Label();
            labelCoins = new Label();
            label = new Label();
            towardCar2 = new PictureBox();
            towardCar1 = new PictureBox();
            towardCar3 = new PictureBox();
            Coin3 = new PictureBox();
            Coin2 = new PictureBox();
            Coin1 = new PictureBox();
            buttonPause = new Button();
            mainCar = new PictureBox();
            LaneTwo5 = new Label();
            LaneTwo4 = new Label();
            LaneTwo3 = new Label();
            LaneTwo2 = new Label();
            LaneTwo1 = new Label();
            LaneOne5 = new Label();
            LaneOne4 = new Label();
            LaneOne3 = new Label();
            LaneOne2 = new Label();
            LaneOne1 = new Label();
            MiddleLane = new Label();
            timerTowardCars = new System.Windows.Forms.Timer(components);
            timerMenu = new System.Windows.Forms.Timer(components);
            panelGame.SuspendLayout();
            panelPause.SuspendLayout();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)carMenu1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carMenu3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carMenu2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureFlag).BeginInit();
            ((System.ComponentModel.ISupportInitialize)towardCar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)towardCar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)towardCar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Coin3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Coin2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Coin1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mainCar).BeginInit();
            SuspendLayout();
            // 
            // timerRoad
            // 
            timerRoad.Enabled = true;
            timerRoad.Interval = 1;
            timerRoad.Tick += timerRoad_Tick;
            // 
            // panelGame
            // 
            panelGame.BackColor = SystemColors.ControlDarkDark;
            panelGame.Controls.Add(panelPause);
            panelGame.Controls.Add(labelScore);
            panelGame.Controls.Add(labelCoins);
            panelGame.Controls.Add(label);
            panelGame.Controls.Add(towardCar2);
            panelGame.Controls.Add(towardCar1);
            panelGame.Controls.Add(towardCar3);
            panelGame.Controls.Add(Coin3);
            panelGame.Controls.Add(Coin2);
            panelGame.Controls.Add(Coin1);
            panelGame.Controls.Add(buttonPause);
            panelGame.Controls.Add(mainCar);
            panelGame.Controls.Add(LaneTwo5);
            panelGame.Controls.Add(LaneTwo4);
            panelGame.Controls.Add(LaneTwo3);
            panelGame.Controls.Add(LaneTwo2);
            panelGame.Controls.Add(LaneTwo1);
            panelGame.Controls.Add(LaneOne5);
            panelGame.Controls.Add(LaneOne4);
            panelGame.Controls.Add(LaneOne3);
            panelGame.Controls.Add(LaneOne2);
            panelGame.Controls.Add(LaneOne1);
            panelGame.Controls.Add(MiddleLane);
            panelGame.Location = new Point(0, 0);
            panelGame.Margin = new Padding(4);
            panelGame.Name = "panelGame";
            panelGame.Size = new Size(448, 650);
            panelGame.TabIndex = 0;
            // 
            // panelPause
            // 
            panelPause.BackColor = SystemColors.ControlDarkDark;
            panelPause.Controls.Add(panelMenu);
            panelPause.Controls.Add(buttonExit);
            panelPause.Controls.Add(buttonResume);
            panelPause.Controls.Add(pictureFlag);
            panelPause.Controls.Add(labelPause);
            panelPause.Location = new Point(0, 0);
            panelPause.Margin = new Padding(4);
            panelPause.Name = "panelPause";
            panelPause.Size = new Size(451, 654);
            panelPause.TabIndex = 57;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.ControlDarkDark;
            panelMenu.Controls.Add(resultsButton);
            panelMenu.Controls.Add(nameTextBox);
            panelMenu.Controls.Add(buttonHelp);
            panelMenu.Controls.Add(buttonMenuExit);
            panelMenu.Controls.Add(buttonStart);
            panelMenu.Controls.Add(label3);
            panelMenu.Controls.Add(carMenu1);
            panelMenu.Controls.Add(carMenu3);
            panelMenu.Controls.Add(carMenu2);
            panelMenu.Controls.Add(menuTwoLane5);
            panelMenu.Controls.Add(menuTwoLane4);
            panelMenu.Controls.Add(menuTwoLane3);
            panelMenu.Controls.Add(menuTwoLane2);
            panelMenu.Controls.Add(menuTwoLane1);
            panelMenu.Controls.Add(MenuOneLane5);
            panelMenu.Controls.Add(menuOneLane4);
            panelMenu.Controls.Add(menuOneLane3);
            panelMenu.Controls.Add(menuOneLane2);
            panelMenu.Controls.Add(menuOneLane1);
            panelMenu.Controls.Add(label12);
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(447, 650);
            panelMenu.TabIndex = 57;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // resultsButton
            // 
            resultsButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            resultsButton.Location = new Point(154, 420);
            resultsButton.Name = "resultsButton";
            resultsButton.Size = new Size(143, 46);
            resultsButton.TabIndex = 84;
            resultsButton.Text = "Results";
            resultsButton.UseVisualStyleBackColor = true;
            //resultsButton.Click += resultsButton_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(161, 224);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(136, 23);
            nameTextBox.TabIndex = 83;
            // 
            // buttonHelp
            // 
            buttonHelp.Font = new Font("Microsoft YaHei", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonHelp.Location = new Point(361, 609);
            buttonHelp.Margin = new Padding(4);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(81, 37);
            buttonHelp.TabIndex = 82;
            buttonHelp.Text = "Help";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonMenuExit
            // 
            buttonMenuExit.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMenuExit.Location = new Point(150, 348);
            buttonMenuExit.Margin = new Padding(4);
            buttonMenuExit.Name = "buttonMenuExit";
            buttonMenuExit.Size = new Size(154, 54);
            buttonMenuExit.TabIndex = 67;
            buttonMenuExit.Text = "Exit";
            buttonMenuExit.UseVisualStyleBackColor = true;
            buttonMenuExit.Click += buttonMenuExit_Click;
            // 
            // buttonStart
            // 
            buttonStart.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStart.Location = new Point(139, 260);
            buttonStart.Margin = new Padding(4);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(186, 68);
            buttonStart.TabIndex = 65;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(64, 64, 64);
            label3.Font = new Font("Microsoft Tai Le", 105F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(384, 178);
            label3.TabIndex = 66;
            label3.Text = "Race";
            // 
            // carMenu1
            // 
            carMenu1.BackColor = Color.Transparent;
            carMenu1.Image = (Image)resources.GetObject("carMenu1.Image");
            carMenu1.Location = new Point(-3, 0);
            carMenu1.Margin = new Padding(4);
            carMenu1.Name = "carMenu1";
            carMenu1.Size = new Size(59, 127);
            carMenu1.SizeMode = PictureBoxSizeMode.Zoom;
            carMenu1.TabIndex = 80;
            carMenu1.TabStop = false;
            // 
            // carMenu3
            // 
            carMenu3.BackColor = Color.Transparent;
            carMenu3.Image = (Image)resources.GetObject("carMenu3.Image");
            carMenu3.Location = new Point(375, 30);
            carMenu3.Margin = new Padding(4);
            carMenu3.Name = "carMenu3";
            carMenu3.Size = new Size(59, 127);
            carMenu3.SizeMode = PictureBoxSizeMode.Zoom;
            carMenu3.TabIndex = 81;
            carMenu3.TabStop = false;
            // 
            // carMenu2
            // 
            carMenu2.BackColor = Color.Transparent;
            carMenu2.Image = (Image)resources.GetObject("carMenu2.Image");
            carMenu2.Location = new Point(150, 4);
            carMenu2.Margin = new Padding(4);
            carMenu2.Name = "carMenu2";
            carMenu2.Size = new Size(59, 127);
            carMenu2.SizeMode = PictureBoxSizeMode.Zoom;
            carMenu2.TabIndex = 79;
            carMenu2.TabStop = false;
            // 
            // menuTwoLane5
            // 
            menuTwoLane5.BackColor = Color.White;
            menuTwoLane5.ForeColor = SystemColors.Control;
            menuTwoLane5.Location = new Point(337, 598);
            menuTwoLane5.Margin = new Padding(4, 0, 4, 0);
            menuTwoLane5.Name = "menuTwoLane5";
            menuTwoLane5.Size = new Size(18, 104);
            menuTwoLane5.TabIndex = 78;
            menuTwoLane5.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuTwoLane4
            // 
            menuTwoLane4.BackColor = Color.White;
            menuTwoLane4.ForeColor = SystemColors.Control;
            menuTwoLane4.Location = new Point(337, 436);
            menuTwoLane4.Margin = new Padding(4, 0, 4, 0);
            menuTwoLane4.Name = "menuTwoLane4";
            menuTwoLane4.Size = new Size(18, 104);
            menuTwoLane4.TabIndex = 77;
            menuTwoLane4.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuTwoLane3
            // 
            menuTwoLane3.BackColor = Color.White;
            menuTwoLane3.ForeColor = SystemColors.Control;
            menuTwoLane3.Location = new Point(337, 274);
            menuTwoLane3.Margin = new Padding(4, 0, 4, 0);
            menuTwoLane3.Name = "menuTwoLane3";
            menuTwoLane3.Size = new Size(18, 104);
            menuTwoLane3.TabIndex = 76;
            menuTwoLane3.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuTwoLane2
            // 
            menuTwoLane2.BackColor = Color.White;
            menuTwoLane2.ForeColor = SystemColors.Control;
            menuTwoLane2.Location = new Point(337, 113);
            menuTwoLane2.Margin = new Padding(4, 0, 4, 0);
            menuTwoLane2.Name = "menuTwoLane2";
            menuTwoLane2.Size = new Size(18, 104);
            menuTwoLane2.TabIndex = 75;
            menuTwoLane2.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuTwoLane1
            // 
            menuTwoLane1.BackColor = Color.White;
            menuTwoLane1.ForeColor = SystemColors.Control;
            menuTwoLane1.Location = new Point(337, -49);
            menuTwoLane1.Margin = new Padding(4, 0, 4, 0);
            menuTwoLane1.Name = "menuTwoLane1";
            menuTwoLane1.Size = new Size(18, 104);
            menuTwoLane1.TabIndex = 74;
            menuTwoLane1.TextAlign = ContentAlignment.TopCenter;
            // 
            // MenuOneLane5
            // 
            MenuOneLane5.BackColor = Color.White;
            MenuOneLane5.ForeColor = SystemColors.Control;
            MenuOneLane5.Location = new Point(104, 598);
            MenuOneLane5.Margin = new Padding(4, 0, 4, 0);
            MenuOneLane5.Name = "MenuOneLane5";
            MenuOneLane5.Size = new Size(18, 104);
            MenuOneLane5.TabIndex = 73;
            MenuOneLane5.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuOneLane4
            // 
            menuOneLane4.BackColor = Color.White;
            menuOneLane4.ForeColor = SystemColors.Control;
            menuOneLane4.Location = new Point(104, 436);
            menuOneLane4.Margin = new Padding(4, 0, 4, 0);
            menuOneLane4.Name = "menuOneLane4";
            menuOneLane4.Size = new Size(18, 104);
            menuOneLane4.TabIndex = 72;
            menuOneLane4.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuOneLane3
            // 
            menuOneLane3.BackColor = Color.White;
            menuOneLane3.ForeColor = SystemColors.Control;
            menuOneLane3.Location = new Point(104, 274);
            menuOneLane3.Margin = new Padding(4, 0, 4, 0);
            menuOneLane3.Name = "menuOneLane3";
            menuOneLane3.Size = new Size(18, 104);
            menuOneLane3.TabIndex = 71;
            menuOneLane3.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuOneLane2
            // 
            menuOneLane2.BackColor = Color.White;
            menuOneLane2.ForeColor = SystemColors.Control;
            menuOneLane2.Location = new Point(104, 113);
            menuOneLane2.Margin = new Padding(4, 0, 4, 0);
            menuOneLane2.Name = "menuOneLane2";
            menuOneLane2.Size = new Size(18, 104);
            menuOneLane2.TabIndex = 70;
            menuOneLane2.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuOneLane1
            // 
            menuOneLane1.BackColor = Color.White;
            menuOneLane1.ForeColor = SystemColors.Control;
            menuOneLane1.Location = new Point(104, -49);
            menuOneLane1.Margin = new Padding(4, 0, 4, 0);
            menuOneLane1.Name = "menuOneLane1";
            menuOneLane1.Size = new Size(18, 104);
            menuOneLane1.TabIndex = 69;
            menuOneLane1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label12
            // 
            label12.BackColor = Color.White;
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(214, -4);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(20, 654);
            label12.TabIndex = 68;
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.Location = new Point(139, 555);
            buttonExit.Margin = new Padding(4);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(178, 46);
            buttonExit.TabIndex = 53;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonResume
            // 
            buttonResume.Font = new Font("Microsoft YaHei", 22F, FontStyle.Bold, GraphicsUnit.Point);
            buttonResume.Location = new Point(139, 469);
            buttonResume.Margin = new Padding(4);
            buttonResume.Name = "buttonResume";
            buttonResume.Size = new Size(178, 67);
            buttonResume.TabIndex = 52;
            buttonResume.Text = "Resume";
            buttonResume.UseVisualStyleBackColor = true;
            buttonResume.Click += buttonResume_Click;
            // 
            // pictureFlag
            // 
            pictureFlag.BackColor = SystemColors.ControlDarkDark;
            pictureFlag.Image = (Image)resources.GetObject("pictureFlag.Image");
            pictureFlag.Location = new Point(-3, 124);
            pictureFlag.Margin = new Padding(4);
            pictureFlag.Name = "pictureFlag";
            pictureFlag.Size = new Size(451, 364);
            pictureFlag.SizeMode = PictureBoxSizeMode.Zoom;
            pictureFlag.TabIndex = 55;
            pictureFlag.TabStop = false;
            // 
            // labelPause
            // 
            labelPause.AutoSize = true;
            labelPause.Font = new Font("Microsoft YaHei", 90F, FontStyle.Bold, GraphicsUnit.Point);
            labelPause.Location = new Point(0, 0);
            labelPause.Margin = new Padding(4, 0, 4, 0);
            labelPause.Name = "labelPause";
            labelPause.Size = new Size(422, 159);
            labelPause.TabIndex = 54;
            labelPause.Text = "Pause";
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.BackColor = Color.Black;
            labelScore.Font = new Font("Microsoft YaHei", 22F, FontStyle.Bold, GraphicsUnit.Point);
            labelScore.ForeColor = SystemColors.ButtonHighlight;
            labelScore.Location = new Point(14, 10);
            labelScore.Margin = new Padding(4, 0, 4, 0);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(110, 40);
            labelScore.TabIndex = 56;
            labelScore.Text = "Score:";
            // 
            // labelCoins
            // 
            labelCoins.AutoSize = true;
            labelCoins.BackColor = Color.Black;
            labelCoins.Font = new Font("Microsoft YaHei", 22F, FontStyle.Bold, GraphicsUnit.Point);
            labelCoins.ForeColor = SystemColors.ButtonHighlight;
            labelCoins.Location = new Point(242, 10);
            labelCoins.Margin = new Padding(4, 0, 4, 0);
            labelCoins.Name = "labelCoins";
            labelCoins.Size = new Size(109, 40);
            labelCoins.TabIndex = 57;
            labelCoins.Text = "Coins:";
            // 
            // label
            // 
            label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label.BackColor = SystemColors.ActiveCaptionText;
            label.Font = new Font("Microsoft Sans Serif", 100F, FontStyle.Regular, GraphicsUnit.Point);
            label.ForeColor = SystemColors.ControlText;
            label.Location = new Point(-3, 0);
            label.Margin = new Padding(4, 0, 4, 0);
            label.Name = "label";
            label.Size = new Size(451, 68);
            label.TabIndex = 55;
            // 
            // towardCar2
            // 
            towardCar2.BackColor = Color.Transparent;
            towardCar2.Image = (Image)resources.GetObject("towardCar2.Image");
            towardCar2.Location = new Point(14, 26);
            towardCar2.Margin = new Padding(4);
            towardCar2.Name = "towardCar2";
            towardCar2.Size = new Size(59, 127);
            towardCar2.SizeMode = PictureBoxSizeMode.Zoom;
            towardCar2.TabIndex = 49;
            towardCar2.TabStop = false;
            // 
            // towardCar1
            // 
            towardCar1.BackColor = Color.Transparent;
            towardCar1.Image = (Image)resources.GetObject("towardCar1.Image");
            towardCar1.Location = new Point(150, 15);
            towardCar1.Margin = new Padding(4);
            towardCar1.Name = "towardCar1";
            towardCar1.Size = new Size(59, 127);
            towardCar1.SizeMode = PictureBoxSizeMode.Zoom;
            towardCar1.TabIndex = 48;
            towardCar1.TabStop = false;
            // 
            // towardCar3
            // 
            towardCar3.BackColor = Color.Transparent;
            towardCar3.Image = (Image)resources.GetObject("towardCar3.Image");
            towardCar3.Location = new Point(375, 41);
            towardCar3.Margin = new Padding(4);
            towardCar3.Name = "towardCar3";
            towardCar3.Size = new Size(59, 127);
            towardCar3.SizeMode = PictureBoxSizeMode.Zoom;
            towardCar3.TabIndex = 50;
            towardCar3.TabStop = false;
            // 
            // Coin3
            // 
            Coin3.BackColor = Color.Transparent;
            Coin3.Image = (Image)resources.GetObject("Coin3.Image");
            Coin3.Location = new Point(375, 257);
            Coin3.Margin = new Padding(4);
            Coin3.Name = "Coin3";
            Coin3.Size = new Size(39, 37);
            Coin3.SizeMode = PictureBoxSizeMode.Zoom;
            Coin3.TabIndex = 54;
            Coin3.TabStop = false;
            // 
            // Coin2
            // 
            Coin2.BackColor = Color.Transparent;
            Coin2.Image = (Image)resources.GetObject("Coin2.Image");
            Coin2.Location = new Point(258, 180);
            Coin2.Margin = new Padding(4);
            Coin2.Name = "Coin2";
            Coin2.Size = new Size(39, 37);
            Coin2.SizeMode = PictureBoxSizeMode.Zoom;
            Coin2.TabIndex = 53;
            Coin2.TabStop = false;
            // 
            // Coin1
            // 
            Coin1.BackColor = Color.Transparent;
            Coin1.Image = (Image)resources.GetObject("Coin1.Image");
            Coin1.Location = new Point(129, 291);
            Coin1.Margin = new Padding(4);
            Coin1.Name = "Coin1";
            Coin1.Size = new Size(39, 37);
            Coin1.SizeMode = PictureBoxSizeMode.Zoom;
            Coin1.TabIndex = 52;
            Coin1.TabStop = false;
            // 
            // buttonPause
            // 
            buttonPause.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPause.Location = new Point(0, 602);
            buttonPause.Margin = new Padding(4);
            buttonPause.Name = "buttonPause";
            buttonPause.Size = new Size(95, 44);
            buttonPause.TabIndex = 1;
            buttonPause.Text = "Pause";
            buttonPause.UseVisualStyleBackColor = true;
            buttonPause.Click += buttonPause_Click;
            // 
            // mainCar
            // 
            mainCar.BackColor = Color.Transparent;
            mainCar.BackgroundImageLayout = ImageLayout.None;
            mainCar.Image = (Image)resources.GetObject("mainCar.Image");
            mainCar.Location = new Point(258, 508);
            mainCar.Margin = new Padding(4);
            mainCar.Name = "mainCar";
            mainCar.Size = new Size(59, 127);
            mainCar.SizeMode = PictureBoxSizeMode.Zoom;
            mainCar.TabIndex = 47;
            mainCar.TabStop = false;
            // 
            // LaneTwo5
            // 
            LaneTwo5.BackColor = Color.White;
            LaneTwo5.ForeColor = SystemColors.Control;
            LaneTwo5.Location = new Point(337, 609);
            LaneTwo5.Margin = new Padding(4, 0, 4, 0);
            LaneTwo5.Name = "LaneTwo5";
            LaneTwo5.Size = new Size(18, 104);
            LaneTwo5.TabIndex = 43;
            LaneTwo5.TextAlign = ContentAlignment.TopCenter;
            // 
            // LaneTwo4
            // 
            LaneTwo4.BackColor = Color.White;
            LaneTwo4.ForeColor = SystemColors.Control;
            LaneTwo4.Location = new Point(337, 447);
            LaneTwo4.Margin = new Padding(4, 0, 4, 0);
            LaneTwo4.Name = "LaneTwo4";
            LaneTwo4.Size = new Size(18, 104);
            LaneTwo4.TabIndex = 42;
            LaneTwo4.TextAlign = ContentAlignment.TopCenter;
            // 
            // LaneTwo3
            // 
            LaneTwo3.BackColor = Color.White;
            LaneTwo3.ForeColor = SystemColors.Control;
            LaneTwo3.Location = new Point(337, 286);
            LaneTwo3.Margin = new Padding(4, 0, 4, 0);
            LaneTwo3.Name = "LaneTwo3";
            LaneTwo3.Size = new Size(18, 104);
            LaneTwo3.TabIndex = 41;
            LaneTwo3.TextAlign = ContentAlignment.TopCenter;
            // 
            // LaneTwo2
            // 
            LaneTwo2.BackColor = Color.White;
            LaneTwo2.ForeColor = SystemColors.Control;
            LaneTwo2.Location = new Point(337, 124);
            LaneTwo2.Margin = new Padding(4, 0, 4, 0);
            LaneTwo2.Name = "LaneTwo2";
            LaneTwo2.Size = new Size(18, 104);
            LaneTwo2.TabIndex = 40;
            LaneTwo2.TextAlign = ContentAlignment.TopCenter;
            // 
            // LaneTwo1
            // 
            LaneTwo1.BackColor = Color.White;
            LaneTwo1.ForeColor = SystemColors.Control;
            LaneTwo1.Location = new Point(337, -37);
            LaneTwo1.Margin = new Padding(4, 0, 4, 0);
            LaneTwo1.Name = "LaneTwo1";
            LaneTwo1.Size = new Size(18, 104);
            LaneTwo1.TabIndex = 39;
            LaneTwo1.TextAlign = ContentAlignment.TopCenter;
            // 
            // LaneOne5
            // 
            LaneOne5.BackColor = Color.White;
            LaneOne5.ForeColor = SystemColors.Control;
            LaneOne5.Location = new Point(104, 609);
            LaneOne5.Margin = new Padding(4, 0, 4, 0);
            LaneOne5.Name = "LaneOne5";
            LaneOne5.Size = new Size(18, 104);
            LaneOne5.TabIndex = 38;
            LaneOne5.TextAlign = ContentAlignment.TopCenter;
            // 
            // LaneOne4
            // 
            LaneOne4.BackColor = Color.White;
            LaneOne4.ForeColor = SystemColors.Control;
            LaneOne4.Location = new Point(104, 448);
            LaneOne4.Margin = new Padding(4, 0, 4, 0);
            LaneOne4.Name = "LaneOne4";
            LaneOne4.Size = new Size(18, 104);
            LaneOne4.TabIndex = 37;
            LaneOne4.TextAlign = ContentAlignment.TopCenter;
            // 
            // LaneOne3
            // 
            LaneOne3.BackColor = Color.White;
            LaneOne3.ForeColor = SystemColors.Control;
            LaneOne3.Location = new Point(104, 286);
            LaneOne3.Margin = new Padding(4, 0, 4, 0);
            LaneOne3.Name = "LaneOne3";
            LaneOne3.Size = new Size(18, 104);
            LaneOne3.TabIndex = 36;
            LaneOne3.TextAlign = ContentAlignment.TopCenter;
            // 
            // LaneOne2
            // 
            LaneOne2.BackColor = Color.White;
            LaneOne2.ForeColor = SystemColors.Control;
            LaneOne2.Location = new Point(104, 124);
            LaneOne2.Margin = new Padding(4, 0, 4, 0);
            LaneOne2.Name = "LaneOne2";
            LaneOne2.Size = new Size(18, 104);
            LaneOne2.TabIndex = 35;
            LaneOne2.TextAlign = ContentAlignment.TopCenter;
            // 
            // LaneOne1
            // 
            LaneOne1.BackColor = Color.White;
            LaneOne1.ForeColor = SystemColors.Control;
            LaneOne1.Location = new Point(104, -37);
            LaneOne1.Margin = new Padding(4, 0, 4, 0);
            LaneOne1.Name = "LaneOne1";
            LaneOne1.Size = new Size(18, 104);
            LaneOne1.TabIndex = 34;
            LaneOne1.TextAlign = ContentAlignment.TopCenter;
            // 
            // MiddleLane
            // 
            MiddleLane.BackColor = Color.White;
            MiddleLane.ForeColor = SystemColors.Control;
            MiddleLane.Location = new Point(214, -4);
            MiddleLane.Margin = new Padding(4, 0, 4, 0);
            MiddleLane.Name = "MiddleLane";
            MiddleLane.Size = new Size(20, 654);
            MiddleLane.TabIndex = 33;
            MiddleLane.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timerTowardCars
            // 
            timerTowardCars.Enabled = true;
            timerTowardCars.Interval = 1;
            timerTowardCars.Tick += timerTowardCars_Tick;
            // 
            // timerMenu
            // 
            timerMenu.Enabled = true;
            timerMenu.Interval = 1;
            timerMenu.Tick += timerMenu_Tick;
            // 
            // RaceGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(448, 649);
            Controls.Add(panelGame);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            KeyPreview = true;
            Margin = new Padding(4);
            Name = "RaceGame";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Race";
            Load += RaceGame_Load;
            KeyDown += RaceGame_KeyDown;
            panelGame.ResumeLayout(false);
            panelGame.PerformLayout();
            panelPause.ResumeLayout(false);
            panelPause.PerformLayout();
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)carMenu1).EndInit();
            ((System.ComponentModel.ISupportInitialize)carMenu3).EndInit();
            ((System.ComponentModel.ISupportInitialize)carMenu2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureFlag).EndInit();
            ((System.ComponentModel.ISupportInitialize)towardCar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)towardCar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)towardCar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Coin3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Coin2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Coin1).EndInit();
            ((System.ComponentModel.ISupportInitialize)mainCar).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timerRoad;
        private Panel panelGame;
        private Label LaneTwo5;
        private Label LaneTwo4;
        private Label LaneTwo3;
        private Label LaneTwo2;
        private Label LaneTwo1;
        private Label LaneOne5;
        private Label LaneOne4;
        private Label LaneOne3;
        private Label LaneOne2;
        private Label LaneOne1;
        private Label MiddleLane;
        private PictureBox towardCar2;
        private PictureBox towardCar3;
        private PictureBox towardCar1;
        private PictureBox mainCar;
        private System.Windows.Forms.Timer timerTowardCars;
        private System.Windows.Forms.Timer timerMenu;
        private Label labelPause;
        private Button buttonExit;
        private Button buttonResume;
        private Button buttonPause;
        private PictureBox Coin1;
        private PictureBox Coin3;
        private PictureBox Coin2;
        private Panel panelPause;
        private PictureBox pictureFlag;
        private Label labelCoins;
        private Label labelScore;
        private Label label;
        private Panel panelMenu;
        private Button buttonHelp;
        private Button buttonMenuExit;
        private Button buttonStart;
        private Label label3;
        private PictureBox carMenu1;
        private PictureBox carMenu3;
        private PictureBox carMenu2;
        private Label menuTwoLane5;
        private Label menuTwoLane4;
        private Label menuTwoLane3;
        private Label menuTwoLane2;
        private Label menuTwoLane1;
        private Label MenuOneLane5;
        private Label menuOneLane4;
        private Label menuOneLane3;
        private Label menuOneLane2;
        private Label menuOneLane1;
        private Label label12;
        private Button resultsButton;
        private TextBox nameTextBox;
    }
}