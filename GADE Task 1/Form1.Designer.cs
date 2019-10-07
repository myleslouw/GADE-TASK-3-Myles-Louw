namespace GADE_Task_1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbxGameProgression = new System.Windows.Forms.ListBox();
            this.lblRound = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.PictureBox();
            this.lblRoundCount = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbxGameProgress = new System.Windows.Forms.GroupBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).BeginInit();
            this.gbxGameProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(40, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 328);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Map";
            // 
            // rtbxGameProgression
            // 
            this.rtbxGameProgression.FormattingEnabled = true;
            this.rtbxGameProgression.Location = new System.Drawing.Point(15, 29);
            this.rtbxGameProgression.Name = "rtbxGameProgression";
            this.rtbxGameProgression.Size = new System.Drawing.Size(374, 264);
            this.rtbxGameProgression.TabIndex = 0;
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Location = new System.Drawing.Point(53, 457);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(53, 13);
            this.lblRound.TabIndex = 3;
            this.lblRound.Text = "ROUND: ";
            // 
            // btnPause
            // 
            this.btnPause.Image = global::GADE_Task_1.Properties.Resources.pause;
            this.btnPause.Location = new System.Drawing.Point(788, 485);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(100, 100);
            this.btnPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPause.TabIndex = 6;
            this.btnPause.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Image = global::GADE_Task_1.Properties.Resources.play;
            this.btnStart.Location = new System.Drawing.Point(633, 485);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 100);
            this.btnStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStart.TabIndex = 5;
            this.btnStart.TabStop = false;
            // 
            // lblRoundCount
            // 
            this.lblRoundCount.AutoSize = true;
            this.lblRoundCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundCount.Location = new System.Drawing.Point(112, 457);
            this.lblRoundCount.Name = "lblRoundCount";
            this.lblRoundCount.Size = new System.Drawing.Size(32, 33);
            this.lblRoundCount.TabIndex = 7;
            this.lblRoundCount.Text = "0";
            // 
            // gbxGameProgress
            // 
            this.gbxGameProgress.Controls.Add(this.rtbxGameProgression);
            this.gbxGameProgress.Location = new System.Drawing.Point(549, 66);
            this.gbxGameProgress.Name = "gbxGameProgress";
            this.gbxGameProgress.Size = new System.Drawing.Size(404, 299);
            this.gbxGameProgress.TabIndex = 8;
            this.gbxGameProgress.TabStop = false;
            this.gbxGameProgress.Text = "Game Progression";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(992, 615);
            this.Controls.Add(this.gbxGameProgress);
            this.Controls.Add(this.lblRoundCount);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).EndInit();
            this.gbxGameProgress.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox rtbxGameProgression;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.PictureBox btnStart;
        private System.Windows.Forms.PictureBox btnPause;
        private System.Windows.Forms.Label lblRoundCount;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbxGameProgress;
        private System.Windows.Forms.Timer gameTimer;
    }
}

