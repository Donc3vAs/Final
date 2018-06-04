namespace Baigiamasis_dabras
{
    partial class LoginFrm
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
            this.LoginB = new System.Windows.Forms.Button();
            this.ExitB = new System.Windows.Forms.Button();
            this.Userlabel = new System.Windows.Forms.Label();
            this.Passlabel2 = new System.Windows.Forms.Label();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoginB
            // 
            this.LoginB.Location = new System.Drawing.Point(121, 112);
            this.LoginB.Name = "LoginB";
            this.LoginB.Size = new System.Drawing.Size(75, 23);
            this.LoginB.TabIndex = 0;
            this.LoginB.Text = "Prisijungti";
            this.LoginB.UseVisualStyleBackColor = true;
            this.LoginB.Click += new System.EventHandler(this.LoginB_Click);
            // 
            // ExitB
            // 
            this.ExitB.Location = new System.Drawing.Point(202, 112);
            this.ExitB.Name = "ExitB";
            this.ExitB.Size = new System.Drawing.Size(75, 23);
            this.ExitB.TabIndex = 1;
            this.ExitB.Text = "Išeiti";
            this.ExitB.UseVisualStyleBackColor = true;
            this.ExitB.Click += new System.EventHandler(this.ExitB_Click);
            // 
            // Userlabel
            // 
            this.Userlabel.AutoSize = true;
            this.Userlabel.Location = new System.Drawing.Point(34, 33);
            this.Userlabel.Name = "Userlabel";
            this.Userlabel.Size = new System.Drawing.Size(54, 13);
            this.Userlabel.TabIndex = 2;
            this.Userlabel.Text = "Vartotojas";
            // 
            // Passlabel2
            // 
            this.Passlabel2.AutoSize = true;
            this.Passlabel2.Location = new System.Drawing.Point(36, 73);
            this.Passlabel2.Name = "Passlabel2";
            this.Passlabel2.Size = new System.Drawing.Size(61, 13);
            this.Passlabel2.TabIndex = 3;
            this.Passlabel2.Text = "Slaptažodis";
            // 
            // UserBox
            // 
            this.UserBox.Location = new System.Drawing.Point(121, 30);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(152, 20);
            this.UserBox.TabIndex = 4;
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(121, 70);
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '*';
            this.PassBox.Size = new System.Drawing.Size(152, 20);
            this.PassBox.TabIndex = 5;
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 174);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.Passlabel2);
            this.Controls.Add(this.Userlabel);
            this.Controls.Add(this.ExitB);
            this.Controls.Add(this.LoginB);
            this.Name = "LoginFrm";
            this.Text = "Prisijungti";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginFrm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button LoginB;
        public System.Windows.Forms.Button ExitB;
        public System.Windows.Forms.Label Userlabel;
        public System.Windows.Forms.Label Passlabel2;
        public System.Windows.Forms.TextBox UserBox;
        public System.Windows.Forms.TextBox PassBox;
    }
}

