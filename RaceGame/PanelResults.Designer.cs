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
            dataGridView1 = new DataGridView();
            UserNameColumn = new DataGridViewTextBoxColumn();
            DataTime = new DataGridViewTextBoxColumn();
            Coins = new DataGridViewTextBoxColumn();
            Score = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { UserNameColumn, DataTime, Coins, Score });
            dataGridView1.Location = new Point(1, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(442, 495);
            dataGridView1.TabIndex = 0;
            // 
            // UserNameColumn
            // 
            UserNameColumn.HeaderText = "Имя игрока";
            UserNameColumn.Name = "UserNameColumn";
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
            Controls.Add(dataGridView1);
            Name = "panelResults";
            Text = "Панел результатов";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn UserNameColumn;
        private DataGridViewTextBoxColumn DataTime;
        private DataGridViewTextBoxColumn Coins;
        private DataGridViewTextBoxColumn Score;
    }
}