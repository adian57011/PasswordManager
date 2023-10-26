
namespace PasswordManager
{
    partial class Signup
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
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PassBox2 = new System.Windows.Forms.TextBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.GotoLoginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(117, 68);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(75, 19);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Username";
            // 
            // UserBox
            // 
            this.UserBox.Location = new System.Drawing.Point(249, 67);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(249, 20);
            this.UserBox.TabIndex = 1;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(117, 113);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(71, 19);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password";
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(249, 112);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(249, 20);
            this.PassBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Retype-Password";
            // 
            // PassBox2
            // 
            this.PassBox2.Location = new System.Drawing.Point(249, 159);
            this.PassBox2.Name = "PassBox2";
            this.PassBox2.Size = new System.Drawing.Size(249, 20);
            this.PassBox2.TabIndex = 5;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(199, 228);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(75, 23);
            this.RegisterBtn.TabIndex = 6;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(376, 228);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetBtn.TabIndex = 7;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Signup";
            // 
            // GotoLoginBtn
            // 
            this.GotoLoginBtn.Location = new System.Drawing.Point(249, 295);
            this.GotoLoginBtn.Name = "GotoLoginBtn";
            this.GotoLoginBtn.Size = new System.Drawing.Size(202, 23);
            this.GotoLoginBtn.TabIndex = 9;
            this.GotoLoginBtn.Text = "Go to Login";
            this.GotoLoginBtn.UseVisualStyleBackColor = true;
            this.GotoLoginBtn.Click += new System.EventHandler(this.GotoLoginBtn_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GotoLoginBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.PassBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.UsernameLabel);
            this.Name = "Signup";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PassBox2;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GotoLoginBtn;
    }
}

