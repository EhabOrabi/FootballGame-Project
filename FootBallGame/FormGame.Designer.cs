namespace FootBallGame
{
    partial class FormGame
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.gameOver = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.scrlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.seclbl = new System.Windows.Forms.Label();
            this.minlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameOver)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 150;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(230, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 60);
            this.label5.TabIndex = 26;
            this.label5.Text = "Enter - New Game\r\nESC - EXIT";
            // 
            // gameOver
            // 
            this.gameOver.Image = global::FootBallGame.Properties.Resources.GameOver;
            this.gameOver.Location = new System.Drawing.Point(3, 73);
            this.gameOver.Name = "gameOver";
            this.gameOver.Size = new System.Drawing.Size(594, 374);
            this.gameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gameOver.TabIndex = 25;
            this.gameOver.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(174, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 27);
            this.label4.TabIndex = 24;
            this.label4.Text = "press space to shot the ball";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-13, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(610, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "______________________________________________";
            // 
            // scrlbl
            // 
            this.scrlbl.AutoSize = true;
            this.scrlbl.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrlbl.ForeColor = System.Drawing.Color.Red;
            this.scrlbl.Location = new System.Drawing.Point(110, 13);
            this.scrlbl.Name = "scrlbl";
            this.scrlbl.Size = new System.Drawing.Size(30, 35);
            this.scrlbl.TabIndex = 22;
            this.scrlbl.Text = "0";
            this.scrlbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 35);
            this.label1.TabIndex = 21;
            this.label1.Text = "Score :";
            // 
            // seclbl
            // 
            this.seclbl.AutoSize = true;
            this.seclbl.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seclbl.ForeColor = System.Drawing.Color.Red;
            this.seclbl.Location = new System.Drawing.Point(537, 9);
            this.seclbl.Name = "seclbl";
            this.seclbl.Size = new System.Drawing.Size(60, 45);
            this.seclbl.TabIndex = 20;
            this.seclbl.Text = "60";
            // 
            // minlbl
            // 
            this.minlbl.AutoSize = true;
            this.minlbl.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minlbl.ForeColor = System.Drawing.Color.Red;
            this.minlbl.Location = new System.Drawing.Point(452, 9);
            this.minlbl.Name = "minlbl";
            this.minlbl.Size = new System.Drawing.Size(94, 45);
            this.minlbl.TabIndex = 18;
            this.minlbl.Text = "Time";
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(599, 449);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gameOver);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.scrlbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seclbl);
            this.Controls.Add(this.minlbl);
            this.Name = "FormGame";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGame_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.gameOver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox gameOver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label scrlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label seclbl;
        private System.Windows.Forms.Label minlbl;
    }
}

