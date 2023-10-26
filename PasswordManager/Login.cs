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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UserBox.Text;
            string password = PassBox.Text;

            Encryption es = new Encryption();


            var db = new PassContext();

            User user = db.Users.FirstOrDefault(u => u.Username == username);

            string decipher = es.Decrypt(user.Password);
            if(password == decipher)
            {
                Dashboard f = new Dashboard(user.Id);
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Password!");
            }
        }
    }
}
