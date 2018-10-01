namespace Geoquiz
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelGeoQuiz = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnScores = new System.Windows.Forms.Button();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.tbPlayer = new System.Windows.Forms.TextBox();
            this.lblErrorF1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelGeoQuiz
            // 
            this.labelGeoQuiz.AutoSize = true;
            this.labelGeoQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGeoQuiz.Location = new System.Drawing.Point(73, 63);
            this.labelGeoQuiz.Name = "labelGeoQuiz";
            this.labelGeoQuiz.Size = new System.Drawing.Size(188, 46);
            this.labelGeoQuiz.TabIndex = 0;
            this.labelGeoQuiz.Text = "Geo quiz";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(182, 199);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(92, 26);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnScores
            // 
            this.btnScores.Location = new System.Drawing.Point(64, 199);
            this.btnScores.Name = "btnScores";
            this.btnScores.Size = new System.Drawing.Size(92, 26);
            this.btnScores.TabIndex = 4;
            this.btnScores.Text = "HIGHSCORES";
            this.btnScores.UseVisualStyleBackColor = true;
            this.btnScores.Click += new System.EventHandler(this.btnScores_Click);
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(90, 139);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(35, 13);
            this.lblPlayer.TabIndex = 1;
            this.lblPlayer.Text = "player";
            // 
            // tbPlayer
            // 
            this.tbPlayer.Location = new System.Drawing.Point(142, 136);
            this.tbPlayer.Name = "tbPlayer";
            this.tbPlayer.Size = new System.Drawing.Size(100, 20);
            this.tbPlayer.TabIndex = 2;
            // 
            // lblErrorF1
            // 
            this.lblErrorF1.AutoSize = true;
            this.lblErrorF1.ForeColor = System.Drawing.Color.Silver;
            this.lblErrorF1.Location = new System.Drawing.Point(90, 170);
            this.lblErrorF1.Name = "lblErrorF1";
            this.lblErrorF1.Size = new System.Drawing.Size(74, 13);
            this.lblErrorF1.TabIndex = 5;
            this.lblErrorF1.Text = "Error message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.lblErrorF1);
            this.Controls.Add(this.btnScores);
            this.Controls.Add(this.tbPlayer);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.labelGeoQuiz);
            this.Name = "Form1";
            this.Text = "Geo quiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGeoQuiz;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnScores;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.TextBox tbPlayer;
        private System.Windows.Forms.Label lblErrorF1;
    }
}

