namespace Eggciting_game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ground = new System.Windows.Forms.PictureBox();
            this.basket = new System.Windows.Forms.PictureBox();
            this.egg = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.egg)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.ForestGreen;
            this.ground.Location = new System.Drawing.Point(0, 415);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(801, 36);
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            // 
            // basket
            // 
            this.basket.BackColor = System.Drawing.Color.SkyBlue;
            this.basket.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("basket.BackgroundImage")));
            this.basket.Location = new System.Drawing.Point(361, 370);
            this.basket.Name = "basket";
            this.basket.Size = new System.Drawing.Size(100, 54);
            this.basket.TabIndex = 1;
            this.basket.TabStop = false;
            // 
            // egg
            // 
            this.egg.BackColor = System.Drawing.Color.Azure;
            this.egg.Location = new System.Drawing.Point(402, 12);
            this.egg.Name = "egg";
            this.egg.Size = new System.Drawing.Size(25, 25);
            this.egg.TabIndex = 2;
            this.egg.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 50;
            this.gameTimer.Tick += new System.EventHandler(this.gameTick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(721, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 54);
            this.label2.TabIndex = 4;
            this.label2.Text = "60";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.egg);
            this.Controls.Add(this.basket);
            this.Controls.Add(this.ground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.moveB);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.stopmove);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.egg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox ground;
        private PictureBox basket;
        private PictureBox egg;
        private System.Windows.Forms.Timer gameTimer;
        private Label label1;
        private Label label2;
    }
}