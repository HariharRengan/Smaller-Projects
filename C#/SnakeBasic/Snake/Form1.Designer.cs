namespace Snake
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.Snake = new System.Windows.Forms.PictureBox();
            this.apple = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Snake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 10;
            this.gameTimer.Tick += new System.EventHandler(this.gameTick);
            // 
            // Snake
            // 
            this.Snake.BackColor = System.Drawing.Color.Green;
            this.Snake.Location = new System.Drawing.Point(360, 212);
            this.Snake.Name = "Snake";
            this.Snake.Size = new System.Drawing.Size(30, 30);
            this.Snake.TabIndex = 0;
            this.Snake.TabStop = false;
            // 
            // apple
            // 
            this.apple.BackColor = System.Drawing.Color.Red;
            this.apple.Location = new System.Drawing.Point(481, 212);
            this.apple.Name = "apple";
            this.apple.Size = new System.Drawing.Size(30, 30);
            this.apple.TabIndex = 1;
            this.apple.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.apple);
            this.Controls.Add(this.Snake);
            this.Name = "Form1";
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.snakedown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.snakechange);
            ((System.ComponentModel.ISupportInitialize)(this.Snake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private PictureBox Snake;
        private PictureBox apple;
    }
}