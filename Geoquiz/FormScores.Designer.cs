namespace Geoquiz
{
    partial class FormScores
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
            this.rBtnAllPlayers = new System.Windows.Forms.RadioButton();
            this.comboBplayers = new System.Windows.Forms.ComboBox();
            this.dataGridViewScores = new System.Windows.Forms.DataGridView();
            this.player = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highscore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBackScores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScores)).BeginInit();
            this.SuspendLayout();
            // 
            // rBtnAllPlayers
            // 
            this.rBtnAllPlayers.AutoSize = true;
            this.rBtnAllPlayers.Location = new System.Drawing.Point(13, 19);
            this.rBtnAllPlayers.Name = "rBtnAllPlayers";
            this.rBtnAllPlayers.Size = new System.Drawing.Size(71, 17);
            this.rBtnAllPlayers.TabIndex = 0;
            this.rBtnAllPlayers.TabStop = true;
            this.rBtnAllPlayers.Text = "all players";
            this.rBtnAllPlayers.UseVisualStyleBackColor = true;
            this.rBtnAllPlayers.CheckedChanged += new System.EventHandler(this.rBtnAllPlayers_CheckedChanged);
            // 
            // comboBplayers
            // 
            this.comboBplayers.FormattingEnabled = true;
            this.comboBplayers.Location = new System.Drawing.Point(13, 42);
            this.comboBplayers.Name = "comboBplayers";
            this.comboBplayers.Size = new System.Drawing.Size(118, 21);
            this.comboBplayers.TabIndex = 1;
            this.comboBplayers.Text = "choose player";
            this.comboBplayers.SelectedIndexChanged += new System.EventHandler(this.comboBplayers_SelectedIndexChanged);
            // 
            // dataGridViewScores
            // 
            this.dataGridViewScores.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewScores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewScores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.player,
            this.highscore});
            this.dataGridViewScores.Enabled = false;
            this.dataGridViewScores.GridColor = System.Drawing.Color.White;
            this.dataGridViewScores.Location = new System.Drawing.Point(178, 11);
            this.dataGridViewScores.Name = "dataGridViewScores";
            this.dataGridViewScores.ReadOnly = true;
            this.dataGridViewScores.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewScores.RowHeadersVisible = false;
            this.dataGridViewScores.Size = new System.Drawing.Size(144, 237);
            this.dataGridViewScores.TabIndex = 2;
            // 
            // player
            // 
            this.player.HeaderText = "player";
            this.player.Name = "player";
            this.player.ReadOnly = true;
            this.player.Width = 70;
            // 
            // highscore
            // 
            this.highscore.HeaderText = "highscore";
            this.highscore.Name = "highscore";
            this.highscore.ReadOnly = true;
            this.highscore.Width = 70;
            // 
            // btnBackScores
            // 
            this.btnBackScores.Location = new System.Drawing.Point(13, 225);
            this.btnBackScores.Name = "btnBackScores";
            this.btnBackScores.Size = new System.Drawing.Size(49, 23);
            this.btnBackScores.TabIndex = 3;
            this.btnBackScores.Text = "BACK";
            this.btnBackScores.UseVisualStyleBackColor = true;
            this.btnBackScores.Click += new System.EventHandler(this.btnBackScores_Click);
            // 
            // FormScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.btnBackScores);
            this.Controls.Add(this.dataGridViewScores);
            this.Controls.Add(this.comboBplayers);
            this.Controls.Add(this.rBtnAllPlayers);
            this.Name = "FormScores";
            this.Text = "Highscores";
            this.Load += new System.EventHandler(this.FormScores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rBtnAllPlayers;
        private System.Windows.Forms.ComboBox comboBplayers;
        private System.Windows.Forms.DataGridView dataGridViewScores;
        private System.Windows.Forms.DataGridViewTextBoxColumn player;
        private System.Windows.Forms.DataGridViewTextBoxColumn highscore;
        private System.Windows.Forms.Button btnBackScores;
    }
}