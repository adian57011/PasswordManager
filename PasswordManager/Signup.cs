using PasswordManager.EF;
using PasswordManager.EF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class Signup :Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            string username = UserBox.Text;
            string password = PassBox.Text;

            if(username == null && password == null)
            {
                MessageBox.Show("Provide Username & Password");
            }
            else if(password != PassBox2.Text)
            {
                MessageBox.Show("Passwords do not match");
            }
            else
            {
                Encryption es = new Encryption();
                string cipher = es.Encrypt(password);
                User user = new User()
                {
                    Username = username,
                    Password = cipher
                };

                var db = new PassContext();

                db.Users.Add(user);
                if(db.SaveChanges() > 0)
                {
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Registration Failed");
                }

            }
        }

        private void GotoLoginBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
