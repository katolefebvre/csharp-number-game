namespace KatoLefebvre_Assignment1
{
    partial class GameForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.generateRandom = new System.Windows.Forms.Button();
            this.startNewGame = new System.Windows.Forms.Button();
            this.number1 = new System.Windows.Forms.Label();
            this.number2 = new System.Windows.Forms.Label();
            this.number3 = new System.Windows.Forms.Label();
            this.number4 = new System.Windows.Forms.Label();
            this.number5 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(50, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click \'Generate Random Numbers\' to generate a list of numbers!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // generateRandom
            // 
            this.generateRandom.Location = new System.Drawing.Point(53, 215);
            this.generateRandom.Name = "generateRandom";
            this.generateRandom.Size = new System.Drawing.Size(158, 37);
            this.generateRandom.TabIndex = 2;
            this.generateRandom.Text = "Generate Random Numbers";
            this.generateRandom.UseVisualStyleBackColor = true;
            this.generateRandom.Click += new System.EventHandler(this.GenerateRandom_Click);
            // 
            // startNewGame
            // 
            this.startNewGame.Location = new System.Drawing.Point(273, 215);
            this.startNewGame.Name = "startNewGame";
            this.startNewGame.Size = new System.Drawing.Size(158, 37);
            this.startNewGame.TabIndex = 3;
            this.startNewGame.Text = "Start New Game";
            this.startNewGame.UseVisualStyleBackColor = true;
            this.startNewGame.Click += new System.EventHandler(this.StartNewGame_Click);
            // 
            // number1
            // 
            this.number1.AutoSize = true;
            this.number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.number1.Location = new System.Drawing.Point(48, 124);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(18, 20);
            this.number1.TabIndex = 4;
            this.number1.Text = "0";
            // 
            // number2
            // 
            this.number2.AutoSize = true;
            this.number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.number2.Location = new System.Drawing.Point(140, 124);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(18, 20);
            this.number2.TabIndex = 5;
            this.number2.Text = "0";
            // 
            // number3
            // 
            this.number3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.number3.AutoSize = true;
            this.number3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.number3.Location = new System.Drawing.Point(233, 124);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(18, 20);
            this.number3.TabIndex = 6;
            this.number3.Text = "0";
            // 
            // number4
            // 
            this.number4.AutoSize = true;
            this.number4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.number4.Location = new System.Drawing.Point(327, 124);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(18, 20);
            this.number4.TabIndex = 7;
            this.number4.Text = "0";
            // 
            // number5
            // 
            this.number5.AutoSize = true;
            this.number5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.number5.Location = new System.Drawing.Point(412, 124);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(18, 20);
            this.number5.TabIndex = 8;
            this.number5.Text = "0";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(53, 268);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(378, 23);
            this.progressBar.TabIndex = 9;
            // 
            // scoreLabel
            // 
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.scoreLabel.Location = new System.Drawing.Point(52, 175);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(378, 23);
            this.scoreLabel.TabIndex = 10;
            this.scoreLabel.Text = "Score";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(49, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 63);
            this.label2.TabIndex = 11;
            this.label2.Text = "Rules: Generate 5 random numbers from 0 to 9. The score depends on the frequency " +
    "of the numbers. Player needs a score of 100 to win the game.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.number5);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.startNewGame);
            this.Controls.Add(this.generateRandom);
            this.Controls.Add(this.label1);
            this.Name = "GameForm";
            this.Text = "Kato\'s Number Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generateRandom;
        private System.Windows.Forms.Button startNewGame;
        private System.Windows.Forms.Label number1;
        private System.Windows.Forms.Label number2;
        private System.Windows.Forms.Label number3;
        private System.Windows.Forms.Label number4;
        private System.Windows.Forms.Label number5;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label label2;
    }
}

