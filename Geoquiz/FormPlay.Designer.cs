namespace Geoquiz
{
    partial class FormPlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlay));
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.rBtnCountry = new System.Windows.Forms.RadioButton();
            this.rBtnCapital = new System.Windows.Forms.RadioButton();
            this.rBtnFlag = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblErrorChooseMode = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelChooseMode = new System.Windows.Forms.Panel();
            this.panelPlay = new System.Windows.Forms.Panel();
            this.lblCurrentScore = new System.Windows.Forms.Label();
            this.panelFlag = new System.Windows.Forms.Panel();
            this.picBoxFlag4 = new System.Windows.Forms.PictureBox();
            this.picBoxFlag3 = new System.Windows.Forms.PictureBox();
            this.picBoxFlag2 = new System.Windows.Forms.PictureBox();
            this.picBoxFlag1 = new System.Windows.Forms.PictureBox();
            this.rBtn4f = new System.Windows.Forms.RadioButton();
            this.lblQuestionFlag = new System.Windows.Forms.Label();
            this.rBtn3f = new System.Windows.Forms.RadioButton();
            this.rBtn2f = new System.Windows.Forms.RadioButton();
            this.rBtn1f = new System.Windows.Forms.RadioButton();
            this.lblPName = new System.Windows.Forms.Label();
            this.panelCounCap = new System.Windows.Forms.Panel();
            this.picBoxQuestion = new System.Windows.Forms.PictureBox();
            this.rBtn4 = new System.Windows.Forms.RadioButton();
            this.lblQuestionCounCap = new System.Windows.Forms.Label();
            this.rBtn3 = new System.Windows.Forms.RadioButton();
            this.rBtn2 = new System.Windows.Forms.RadioButton();
            this.rBtn1 = new System.Windows.Forms.RadioButton();
            this.lblPage = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.lblErrorPlay = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.panelPlayEnd = new System.Windows.Forms.Panel();
            this.lblCongrats = new System.Windows.Forms.Label();
            this.lblYourScore = new System.Windows.Forms.Label();
            this.lblPnamePlayEnd = new System.Windows.Forms.Label();
            this.btnPlayEndOk = new System.Windows.Forms.Button();
            this.panelChooseMode.SuspendLayout();
            this.panelPlay.SuspendLayout();
            this.panelFlag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFlag4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFlag3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFlag2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFlag1)).BeginInit();
            this.panelCounCap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQuestion)).BeginInit();
            this.panelPlayEnd.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(72, 35);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(188, 46);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Geo quiz";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(93, 90);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(147, 25);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "choose mode:";
            // 
            // rBtnCountry
            // 
            this.rBtnCountry.AutoSize = true;
            this.rBtnCountry.Location = new System.Drawing.Point(120, 129);
            this.rBtnCountry.Name = "rBtnCountry";
            this.rBtnCountry.Size = new System.Drawing.Size(91, 17);
            this.rBtnCountry.TabIndex = 3;
            this.rBtnCountry.TabStop = true;
            this.rBtnCountry.Text = "guess country";
            this.rBtnCountry.UseVisualStyleBackColor = true;
            // 
            // rBtnCapital
            // 
            this.rBtnCapital.AutoSize = true;
            this.rBtnCapital.Location = new System.Drawing.Point(120, 152);
            this.rBtnCapital.Name = "rBtnCapital";
            this.rBtnCapital.Size = new System.Drawing.Size(87, 17);
            this.rBtnCapital.TabIndex = 4;
            this.rBtnCapital.TabStop = true;
            this.rBtnCapital.Text = "guess capital";
            this.rBtnCapital.UseVisualStyleBackColor = true;
            // 
            // rBtnFlag
            // 
            this.rBtnFlag.AutoSize = true;
            this.rBtnFlag.Location = new System.Drawing.Point(120, 175);
            this.rBtnFlag.Name = "rBtnFlag";
            this.rBtnFlag.Size = new System.Drawing.Size(73, 17);
            this.rBtnFlag.TabIndex = 5;
            this.rBtnFlag.TabStop = true;
            this.rBtnFlag.Text = "guess flag";
            this.rBtnFlag.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(236, 226);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(54, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblErrorChooseMode
            // 
            this.lblErrorChooseMode.AutoSize = true;
            this.lblErrorChooseMode.ForeColor = System.Drawing.Color.Silver;
            this.lblErrorChooseMode.Location = new System.Drawing.Point(126, 207);
            this.lblErrorChooseMode.Name = "lblErrorChooseMode";
            this.lblErrorChooseMode.Size = new System.Drawing.Size(74, 13);
            this.lblErrorChooseMode.TabIndex = 8;
            this.lblErrorChooseMode.Text = "Error message";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(34, 226);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(48, 23);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelChooseMode
            // 
            this.panelChooseMode.Controls.Add(this.lbl1);
            this.panelChooseMode.Controls.Add(this.lbl2);
            this.panelChooseMode.Controls.Add(this.rBtnCountry);
            this.panelChooseMode.Controls.Add(this.rBtnCapital);
            this.panelChooseMode.Controls.Add(this.btnBack);
            this.panelChooseMode.Controls.Add(this.rBtnFlag);
            this.panelChooseMode.Controls.Add(this.lblErrorChooseMode);
            this.panelChooseMode.Controls.Add(this.btnStart);
            this.panelChooseMode.Location = new System.Drawing.Point(0, 0);
            this.panelChooseMode.Name = "panelChooseMode";
            this.panelChooseMode.Size = new System.Drawing.Size(332, 260);
            this.panelChooseMode.TabIndex = 0;
            // 
            // panelPlay
            // 
            this.panelPlay.Controls.Add(this.lblCurrentScore);
            this.panelPlay.Controls.Add(this.panelFlag);
            this.panelPlay.Controls.Add(this.lblPName);
            this.panelPlay.Controls.Add(this.panelCounCap);
            this.panelPlay.Controls.Add(this.lblPage);
            this.panelPlay.Controls.Add(this.btnEnd);
            this.panelPlay.Controls.Add(this.lblErrorPlay);
            this.panelPlay.Controls.Add(this.btnOk);
            this.panelPlay.Location = new System.Drawing.Point(0, 0);
            this.panelPlay.Name = "panelPlay";
            this.panelPlay.Size = new System.Drawing.Size(332, 260);
            this.panelPlay.TabIndex = 0;
            this.panelPlay.Visible = false;
            // 
            // lblCurrentScore
            // 
            this.lblCurrentScore.AutoSize = true;
            this.lblCurrentScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentScore.ForeColor = System.Drawing.Color.Silver;
            this.lblCurrentScore.Location = new System.Drawing.Point(244, 16);
            this.lblCurrentScore.Name = "lblCurrentScore";
            this.lblCurrentScore.Size = new System.Drawing.Size(58, 17);
            this.lblCurrentScore.TabIndex = 3;
            this.lblCurrentScore.Text = "score: ";
            // 
            // panelFlag
            // 
            this.panelFlag.Controls.Add(this.picBoxFlag4);
            this.panelFlag.Controls.Add(this.picBoxFlag3);
            this.panelFlag.Controls.Add(this.picBoxFlag2);
            this.panelFlag.Controls.Add(this.picBoxFlag1);
            this.panelFlag.Controls.Add(this.rBtn4f);
            this.panelFlag.Controls.Add(this.lblQuestionFlag);
            this.panelFlag.Controls.Add(this.rBtn3f);
            this.panelFlag.Controls.Add(this.rBtn2f);
            this.panelFlag.Controls.Add(this.rBtn1f);
            this.panelFlag.Location = new System.Drawing.Point(3, 52);
            this.panelFlag.Name = "panelFlag";
            this.panelFlag.Size = new System.Drawing.Size(326, 135);
            this.panelFlag.TabIndex = 0;
            this.panelFlag.Visible = false;
            // 
            // picBoxFlag4
            // 
            this.picBoxFlag4.Location = new System.Drawing.Point(205, 100);
            this.picBoxFlag4.Name = "picBoxFlag4";
            this.picBoxFlag4.Padding = new System.Windows.Forms.Padding(2);
            this.picBoxFlag4.Size = new System.Drawing.Size(34, 24);
            this.picBoxFlag4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxFlag4.TabIndex = 15;
            this.picBoxFlag4.TabStop = false;
            // 
            // picBoxFlag3
            // 
            this.picBoxFlag3.Location = new System.Drawing.Point(205, 62);
            this.picBoxFlag3.Name = "picBoxFlag3";
            this.picBoxFlag3.Padding = new System.Windows.Forms.Padding(2);
            this.picBoxFlag3.Size = new System.Drawing.Size(34, 24);
            this.picBoxFlag3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxFlag3.TabIndex = 14;
            this.picBoxFlag3.TabStop = false;
            // 
            // picBoxFlag2
            // 
            this.picBoxFlag2.Location = new System.Drawing.Point(107, 100);
            this.picBoxFlag2.Name = "picBoxFlag2";
            this.picBoxFlag2.Padding = new System.Windows.Forms.Padding(2);
            this.picBoxFlag2.Size = new System.Drawing.Size(34, 24);
            this.picBoxFlag2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxFlag2.TabIndex = 13;
            this.picBoxFlag2.TabStop = false;
            // 
            // picBoxFlag1
            // 
            this.picBoxFlag1.Location = new System.Drawing.Point(107, 62);
            this.picBoxFlag1.Name = "picBoxFlag1";
            this.picBoxFlag1.Padding = new System.Windows.Forms.Padding(2);
            this.picBoxFlag1.Size = new System.Drawing.Size(34, 24);
            this.picBoxFlag1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxFlag1.TabIndex = 6;
            this.picBoxFlag1.TabStop = false;
            // 
            // rBtn4f
            // 
            this.rBtn4f.AutoSize = true;
            this.rBtn4f.Location = new System.Drawing.Point(185, 103);
            this.rBtn4f.Name = "rBtn4f";
            this.rBtn4f.Size = new System.Drawing.Size(14, 13);
            this.rBtn4f.TabIndex = 9;
            this.rBtn4f.TabStop = true;
            this.rBtn4f.UseVisualStyleBackColor = true;
            // 
            // lblQuestionFlag
            // 
            this.lblQuestionFlag.AutoSize = true;
            this.lblQuestionFlag.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionFlag.Location = new System.Drawing.Point(12, 15);
            this.lblQuestionFlag.Name = "lblQuestionFlag";
            this.lblQuestionFlag.Size = new System.Drawing.Size(131, 22);
            this.lblQuestionFlag.TabIndex = 4;
            this.lblQuestionFlag.Text = "country, capital";
            // 
            // rBtn3f
            // 
            this.rBtn3f.AutoSize = true;
            this.rBtn3f.Location = new System.Drawing.Point(185, 65);
            this.rBtn3f.Name = "rBtn3f";
            this.rBtn3f.Size = new System.Drawing.Size(14, 13);
            this.rBtn3f.TabIndex = 8;
            this.rBtn3f.TabStop = true;
            this.rBtn3f.UseVisualStyleBackColor = true;
            // 
            // rBtn2f
            // 
            this.rBtn2f.AutoSize = true;
            this.rBtn2f.Location = new System.Drawing.Point(87, 103);
            this.rBtn2f.Name = "rBtn2f";
            this.rBtn2f.Size = new System.Drawing.Size(14, 13);
            this.rBtn2f.TabIndex = 7;
            this.rBtn2f.TabStop = true;
            this.rBtn2f.UseVisualStyleBackColor = true;
            // 
            // rBtn1f
            // 
            this.rBtn1f.AutoSize = true;
            this.rBtn1f.Location = new System.Drawing.Point(87, 65);
            this.rBtn1f.Name = "rBtn1f";
            this.rBtn1f.Size = new System.Drawing.Size(14, 13);
            this.rBtn1f.TabIndex = 5;
            this.rBtn1f.TabStop = true;
            this.rBtn1f.UseVisualStyleBackColor = true;
            // 
            // lblPName
            // 
            this.lblPName.AutoSize = true;
            this.lblPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPName.ForeColor = System.Drawing.Color.Silver;
            this.lblPName.Location = new System.Drawing.Point(99, 16);
            this.lblPName.Name = "lblPName";
            this.lblPName.Size = new System.Drawing.Size(97, 17);
            this.lblPName.TabIndex = 2;
            this.lblPName.Text = "player name";
            this.lblPName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panelCounCap
            // 
            this.panelCounCap.Controls.Add(this.picBoxQuestion);
            this.panelCounCap.Controls.Add(this.rBtn4);
            this.panelCounCap.Controls.Add(this.lblQuestionCounCap);
            this.panelCounCap.Controls.Add(this.rBtn3);
            this.panelCounCap.Controls.Add(this.rBtn2);
            this.panelCounCap.Controls.Add(this.rBtn1);
            this.panelCounCap.Location = new System.Drawing.Point(3, 52);
            this.panelCounCap.Name = "panelCounCap";
            this.panelCounCap.Size = new System.Drawing.Size(326, 135);
            this.panelCounCap.TabIndex = 0;
            this.panelCounCap.Visible = false;
            // 
            // picBoxQuestion
            // 
            this.picBoxQuestion.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBoxQuestion.InitialImage")));
            this.picBoxQuestion.Location = new System.Drawing.Point(17, 16);
            this.picBoxQuestion.Name = "picBoxQuestion";
            this.picBoxQuestion.Size = new System.Drawing.Size(30, 20);
            this.picBoxQuestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxQuestion.TabIndex = 4;
            this.picBoxQuestion.TabStop = false;
            // 
            // rBtn4
            // 
            this.rBtn4.AutoSize = true;
            this.rBtn4.Location = new System.Drawing.Point(166, 93);
            this.rBtn4.Name = "rBtn4";
            this.rBtn4.Size = new System.Drawing.Size(56, 17);
            this.rBtn4.TabIndex = 9;
            this.rBtn4.TabStop = true;
            this.rBtn4.Text = "capital";
            this.rBtn4.UseVisualStyleBackColor = true;
            // 
            // lblQuestionCounCap
            // 
            this.lblQuestionCounCap.AutoSize = true;
            this.lblQuestionCounCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionCounCap.Location = new System.Drawing.Point(53, 15);
            this.lblQuestionCounCap.Name = "lblQuestionCounCap";
            this.lblQuestionCounCap.Size = new System.Drawing.Size(69, 22);
            this.lblQuestionCounCap.TabIndex = 5;
            this.lblQuestionCounCap.Text = "country";
            // 
            // rBtn3
            // 
            this.rBtn3.AutoSize = true;
            this.rBtn3.Location = new System.Drawing.Point(166, 70);
            this.rBtn3.Name = "rBtn3";
            this.rBtn3.Size = new System.Drawing.Size(56, 17);
            this.rBtn3.TabIndex = 8;
            this.rBtn3.TabStop = true;
            this.rBtn3.Text = "capital";
            this.rBtn3.UseVisualStyleBackColor = true;
            // 
            // rBtn2
            // 
            this.rBtn2.AutoSize = true;
            this.rBtn2.Location = new System.Drawing.Point(17, 93);
            this.rBtn2.Name = "rBtn2";
            this.rBtn2.Size = new System.Drawing.Size(56, 17);
            this.rBtn2.TabIndex = 7;
            this.rBtn2.TabStop = true;
            this.rBtn2.Text = "capital";
            this.rBtn2.UseVisualStyleBackColor = true;
            // 
            // rBtn1
            // 
            this.rBtn1.AutoSize = true;
            this.rBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtn1.Location = new System.Drawing.Point(17, 70);
            this.rBtn1.Name = "rBtn1";
            this.rBtn1.Size = new System.Drawing.Size(56, 17);
            this.rBtn1.TabIndex = 6;
            this.rBtn1.TabStop = true;
            this.rBtn1.Text = "capital";
            this.rBtn1.UseVisualStyleBackColor = true;
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.ForeColor = System.Drawing.Color.Silver;
            this.lblPage.Location = new System.Drawing.Point(3, 9);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(58, 26);
            this.lblPage.TabIndex = 1;
            this.lblPage.Text = "0/10";
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(34, 226);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(48, 23);
            this.btnEnd.TabIndex = 11;
            this.btnEnd.Text = "END";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // lblErrorPlay
            // 
            this.lblErrorPlay.AutoSize = true;
            this.lblErrorPlay.ForeColor = System.Drawing.Color.Silver;
            this.lblErrorPlay.Location = new System.Drawing.Point(122, 196);
            this.lblErrorPlay.Name = "lblErrorPlay";
            this.lblErrorPlay.Size = new System.Drawing.Size(74, 13);
            this.lblErrorPlay.TabIndex = 12;
            this.lblErrorPlay.Text = "Error message";
            this.lblErrorPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(237, 226);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(54, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panelPlayEnd
            // 
            this.panelPlayEnd.Controls.Add(this.lblCongrats);
            this.panelPlayEnd.Controls.Add(this.lblYourScore);
            this.panelPlayEnd.Controls.Add(this.lblPnamePlayEnd);
            this.panelPlayEnd.Controls.Add(this.btnPlayEndOk);
            this.panelPlayEnd.Location = new System.Drawing.Point(0, 0);
            this.panelPlayEnd.Name = "panelPlayEnd";
            this.panelPlayEnd.Size = new System.Drawing.Size(332, 260);
            this.panelPlayEnd.TabIndex = 0;
            this.panelPlayEnd.Visible = false;
            // 
            // lblCongrats
            // 
            this.lblCongrats.AutoSize = true;
            this.lblCongrats.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCongrats.ForeColor = System.Drawing.Color.Silver;
            this.lblCongrats.Location = new System.Drawing.Point(51, 46);
            this.lblCongrats.Name = "lblCongrats";
            this.lblCongrats.Size = new System.Drawing.Size(229, 31);
            this.lblCongrats.TabIndex = 1;
            this.lblCongrats.Text = "Congratulations,";
            // 
            // lblYourScore
            // 
            this.lblYourScore.AutoSize = true;
            this.lblYourScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourScore.Location = new System.Drawing.Point(62, 160);
            this.lblYourScore.Name = "lblYourScore";
            this.lblYourScore.Size = new System.Drawing.Size(115, 24);
            this.lblYourScore.TabIndex = 3;
            this.lblYourScore.Text = "your score ";
            // 
            // lblPnamePlayEnd
            // 
            this.lblPnamePlayEnd.AutoSize = true;
            this.lblPnamePlayEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPnamePlayEnd.ForeColor = System.Drawing.Color.Silver;
            this.lblPnamePlayEnd.Location = new System.Drawing.Point(78, 84);
            this.lblPnamePlayEnd.Name = "lblPnamePlayEnd";
            this.lblPnamePlayEnd.Size = new System.Drawing.Size(173, 31);
            this.lblPnamePlayEnd.TabIndex = 2;
            this.lblPnamePlayEnd.Text = "player name";
            this.lblPnamePlayEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlayEndOk
            // 
            this.btnPlayEndOk.Location = new System.Drawing.Point(139, 226);
            this.btnPlayEndOk.Name = "btnPlayEndOk";
            this.btnPlayEndOk.Size = new System.Drawing.Size(54, 23);
            this.btnPlayEndOk.TabIndex = 4;
            this.btnPlayEndOk.Text = "OK";
            this.btnPlayEndOk.UseVisualStyleBackColor = true;
            this.btnPlayEndOk.Click += new System.EventHandler(this.btnPlayEndOk_Click);
            // 
            // FormPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.panelPlayEnd);
            this.Controls.Add(this.panelPlay);
            this.Controls.Add(this.panelChooseMode);
            this.Location = new System.Drawing.Point(400, 0);
            this.Name = "FormPlay";
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.FormPlay_Load);
            this.panelChooseMode.ResumeLayout(false);
            this.panelChooseMode.PerformLayout();
            this.panelPlay.ResumeLayout(false);
            this.panelPlay.PerformLayout();
            this.panelFlag.ResumeLayout(false);
            this.panelFlag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFlag4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFlag3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFlag2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFlag1)).EndInit();
            this.panelCounCap.ResumeLayout(false);
            this.panelCounCap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQuestion)).EndInit();
            this.panelPlayEnd.ResumeLayout(false);
            this.panelPlayEnd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.RadioButton rBtnCountry;
        private System.Windows.Forms.RadioButton rBtnCapital;
        private System.Windows.Forms.RadioButton rBtnFlag;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblErrorChooseMode;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelChooseMode;
        private System.Windows.Forms.Panel panelPlay;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Label lblQuestionCounCap;
        private System.Windows.Forms.RadioButton rBtn1;
        private System.Windows.Forms.RadioButton rBtn2;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.RadioButton rBtn3;
        private System.Windows.Forms.Label lblErrorPlay;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.PictureBox picBoxQuestion;
        private System.Windows.Forms.RadioButton rBtn4;
        private System.Windows.Forms.Panel panelCounCap;
        private System.Windows.Forms.RadioButton rBtn1f;
        private System.Windows.Forms.RadioButton rBtn2f;
        private System.Windows.Forms.RadioButton rBtn3f;
        private System.Windows.Forms.Label lblQuestionFlag;
        private System.Windows.Forms.RadioButton rBtn4f;
        private System.Windows.Forms.Panel panelFlag;
        private System.Windows.Forms.PictureBox picBoxFlag4;
        private System.Windows.Forms.PictureBox picBoxFlag3;
        private System.Windows.Forms.PictureBox picBoxFlag2;
        private System.Windows.Forms.PictureBox picBoxFlag1;
        private System.Windows.Forms.Label lblPName;
        private System.Windows.Forms.Panel panelPlayEnd;
        private System.Windows.Forms.Label lblCongrats;
        private System.Windows.Forms.Label lblYourScore;
        private System.Windows.Forms.Label lblPnamePlayEnd;
        private System.Windows.Forms.Button btnPlayEndOk;
        private System.Windows.Forms.Label lblCurrentScore;
    }
}