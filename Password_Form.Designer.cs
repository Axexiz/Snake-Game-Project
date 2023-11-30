
namespace ZombieProject
{
    partial class Password_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Password_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.LoginBTN = new System.Windows.Forms.Button();
            this.AddAccBTN = new System.Windows.Forms.Button();
            this.RemoveAccBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(99, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(99, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password: ";
            // 
            // UsernameTB
            // 
            this.UsernameTB.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.UsernameTB.Location = new System.Drawing.Point(314, 153);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(312, 39);
            this.UsernameTB.TabIndex = 2;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PasswordTB.Location = new System.Drawing.Point(314, 223);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(312, 39);
            this.PasswordTB.TabIndex = 3;
            // 
            // LoginBTN
            // 
            this.LoginBTN.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LoginBTN.Location = new System.Drawing.Point(314, 339);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(147, 46);
            this.LoginBTN.TabIndex = 4;
            this.LoginBTN.Text = "Login";
            this.LoginBTN.UseVisualStyleBackColor = true;
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            // 
            // AddAccBTN
            // 
            this.AddAccBTN.BackColor = System.Drawing.Color.Transparent;
            this.AddAccBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddAccBTN.FlatAppearance.BorderSize = 0;
            this.AddAccBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AddAccBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AddAccBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAccBTN.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AddAccBTN.ForeColor = System.Drawing.Color.Snow;
            this.AddAccBTN.Location = new System.Drawing.Point(293, 282);
            this.AddAccBTN.Name = "AddAccBTN";
            this.AddAccBTN.Size = new System.Drawing.Size(98, 26);
            this.AddAccBTN.TabIndex = 5;
            this.AddAccBTN.Text = "Add Account";
            this.AddAccBTN.UseVisualStyleBackColor = false;
            this.AddAccBTN.Click += new System.EventHandler(this.AddAccBTN_Click);
            // 
            // RemoveAccBTN
            // 
            this.RemoveAccBTN.BackColor = System.Drawing.Color.Transparent;
            this.RemoveAccBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveAccBTN.FlatAppearance.BorderSize = 0;
            this.RemoveAccBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RemoveAccBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RemoveAccBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveAccBTN.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RemoveAccBTN.ForeColor = System.Drawing.Color.Snow;
            this.RemoveAccBTN.Location = new System.Drawing.Point(397, 282);
            this.RemoveAccBTN.Name = "RemoveAccBTN";
            this.RemoveAccBTN.Size = new System.Drawing.Size(116, 26);
            this.RemoveAccBTN.TabIndex = 6;
            this.RemoveAccBTN.Text = "Remove Account";
            this.RemoveAccBTN.UseVisualStyleBackColor = false;
            this.RemoveAccBTN.Click += new System.EventHandler(this.RemoveAccBTN_Click);
            // 
            // Password_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RemoveAccBTN);
            this.Controls.Add(this.AddAccBTN);
            this.Controls.Add(this.LoginBTN);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.UsernameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Password_Form";
            this.Text = "Password_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsernameTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Button LoginBTN;
        private System.Windows.Forms.Button AddAccBTN;
        private System.Windows.Forms.Button RemoveAccBTN;
    }
}