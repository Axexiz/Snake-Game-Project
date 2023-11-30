
namespace ZombieProject
{
    partial class SnakeGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SnakeGame));
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.txtParts = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtAmmo = new System.Windows.Forms.Label();
            this.txtKills = new System.Windows.Forms.Label();
            this.SpeedBar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.PLayer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PLayer)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 30;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // txtParts
            // 
            this.txtParts.AutoSize = true;
            this.txtParts.BackColor = System.Drawing.Color.Transparent;
            this.txtParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParts.ForeColor = System.Drawing.Color.Snow;
            this.txtParts.Location = new System.Drawing.Point(200, 2);
            this.txtParts.Name = "txtParts";
            this.txtParts.Size = new System.Drawing.Size(112, 33);
            this.txtParts.TabIndex = 5;
            this.txtParts.Text = "parts: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(589, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Health:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(674, 7);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(119, 19);
            this.progressBar1.TabIndex = 0;
            // 
            // txtAmmo
            // 
            this.txtAmmo.AutoSize = true;
            this.txtAmmo.BackColor = System.Drawing.Color.Transparent;
            this.txtAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmmo.ForeColor = System.Drawing.Color.Snow;
            this.txtAmmo.Location = new System.Drawing.Point(12, 2);
            this.txtAmmo.Name = "txtAmmo";
            this.txtAmmo.Size = new System.Drawing.Size(129, 33);
            this.txtAmmo.TabIndex = 2;
            this.txtAmmo.Text = "ammo: 0";
            // 
            // txtKills
            // 
            this.txtKills.AutoSize = true;
            this.txtKills.BackColor = System.Drawing.Color.Transparent;
            this.txtKills.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKills.ForeColor = System.Drawing.Color.Snow;
            this.txtKills.Location = new System.Drawing.Point(113, 2);
            this.txtKills.Name = "txtKills";
            this.txtKills.Size = new System.Drawing.Size(98, 33);
            this.txtKills.TabIndex = 3;
            this.txtKills.Text = "kills: 0";
            // 
            // SpeedBar
            // 
            this.SpeedBar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.SpeedBar.BackColor = System.Drawing.Color.Cyan;
            this.SpeedBar.ForeColor = System.Drawing.Color.Cyan;
            this.SpeedBar.Location = new System.Drawing.Point(450, 7);
            this.SpeedBar.Name = "SpeedBar";
            this.SpeedBar.Size = new System.Drawing.Size(133, 19);
            this.SpeedBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.SpeedBar.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(307, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "SpeedCapacity";
            // 
            // PLayer
            // 
            this.PLayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(75)))), ((int)(((byte)(67)))));
            this.PLayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PLayer.Location = new System.Drawing.Point(384, 232);
            this.PLayer.Margin = new System.Windows.Forms.Padding(0);
            this.PLayer.Name = "PLayer";
            this.PLayer.Size = new System.Drawing.Size(60, 49);
            this.PLayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PLayer.TabIndex = 4;
            this.PLayer.TabStop = false;
            this.PLayer.Tag = "body";
            // 
            // SnakeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(844, 511);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SpeedBar);
            this.Controls.Add(this.PLayer);
            this.Controls.Add(this.txtParts);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAmmo);
            this.Controls.Add(this.txtKills);
            this.DoubleBuffered = true;
            this.Name = "SnakeGame";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SnakeGame_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.PLayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label txtParts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label txtAmmo;
        private System.Windows.Forms.Label txtKills;
        private System.Windows.Forms.ProgressBar SpeedBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PLayer;
    }
}

