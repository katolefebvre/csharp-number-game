namespace KatoLefebvre_Assignment1
{
    partial class ResultForm
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
            this.startNewGame = new System.Windows.Forms.Button();
            this.score = new System.Windows.Forms.Label();
            this.finalresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startNewGame
            // 
            this.startNewGame.Location = new System.Drawing.Point(131, 207);
            this.startNewGame.Name = "startNewGame";
            this.startNewGame.Size = new System.Drawing.Size(221, 52);
            this.startNewGame.TabIndex = 0;
            this.startNewGame.Text = "Start New Game";
            this.startNewGame.UseVisualStyleBackColor = true;
            this.startNewGame.Click += new System.EventHandler(this.StartNewGame_Click);
            // 
            // score
            // 
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.score.Location = new System.Drawing.Point(131, 29);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(221, 113);
            this.score.TabIndex = 1;
            this.score.Text = "Default.";
            this.score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // finalresult
            // 
            this.finalresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.finalresult.Location = new System.Drawing.Point(132, 142);
            this.finalresult.Name = "finalresult";
            this.finalresult.Size = new System.Drawing.Size(221, 62);
            this.finalresult.TabIndex = 2;
            this.finalresult.Text = "Default.";
            this.finalresult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.finalresult);
            this.Controls.Add(this.score);
            this.Controls.Add(this.startNewGame);
            this.Name = "ResultForm";
            this.Text = "Results";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startNewGame;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label finalresult;
    }
}