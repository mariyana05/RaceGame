namespace Race
{
    partial class panelResults
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView = new DataGridView();
            UserName = new DataGridViewTextBoxColumn();
            DataTime = new DataGridViewTextBoxColumn();
            Coins = new DataGridViewTextBoxColumn();
            Score = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { UserName, DataTime, Coins, Score });
            dataGridView.Location = new Point(1, 2);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(442, 495);
            dataGridView.TabIndex = 0;
            // 
            // UserNameColumn
            // 
            UserName.HeaderText = "Имя игрока";
            UserName.Name = "UserName";
            // 
            // DataTime
            // 
            DataTime.HeaderText = "Время";
            DataTime.Name = "DataTime";
            // 
            // Coins
            // 
            Coins.HeaderText = "Монеты";
            Coins.Name = "Coins";
            // 
            // Score
            // 
            Score.HeaderText = "Скорость";
            Score.Name = "Score";
            // 
            // panelResults
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 499);
            Controls.Add(dataGridView);
            Name = "panelResults";
            Text = "Панел результатов";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn DataTime;
        private DataGridViewTextBoxColumn Coins;
        private DataGridViewTextBoxColumn Score;
    }
}