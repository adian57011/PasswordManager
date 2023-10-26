
namespace PasswordManager
{
    partial class Login
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
            this.LoginLabel = new System.Windows.Forms.Label();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.GotoRegBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.Location = new System.Drawing.Point(372, 59);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(46, 19);
            this.LoginLabel.TabIndex = 17;
            this.LoginLabel.Text = "Login";
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(426, 191);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetBtn.TabIndex = 16;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(226, 191);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 15;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(308, 138);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(249, 20);
            this.PassBox.TabIndex = 12;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(176, 139);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(71, 19);
            this.PasswordLabel.TabIndex = 11;
            this.PasswordLabel.Text = "Password";
            // 
            // UserBox
            // 
            this.UserBox.Location = new System.Drawing.Point(308, 93);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(249, 20);
            this.UserBox.TabIndex = 10;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(176, 94);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(75, 19);
            this.UsernameLabel.TabIndex = 9;
            this.UsernameLabel.Text = "Username";
            // 
            // GotoRegBtn
            // 
            this.GotoRegBtn.Location = new System.Drawing.Point(343, 296);
            this.GotoRegBtn.Name = "GotoRegBtn";
            this.GotoRegBtn.Size = new System.Drawing.Size(186, 23);
            this.GotoRegBtn.TabIndex = 18;
            this.GotoRegBtn.Text = "Go to Reg";
            this.GotoRegBtn.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GotoRegBtn);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.UsernameLabel);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Button GotoRegBtn;
    }
}