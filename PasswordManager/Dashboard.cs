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
    public partial class Dashboard : Form
    {
        private User user;
        public Dashboard(int id)
        {
            InitializeComponent();
            var db = new PassContext();

            user = db.Users.Find(id);

            HelloLabel.Text = "Hello"+user.Username;
            HelloLabel.Visible = true;

            Encryption es = new Encryption();
            var data = db.Passwords.Where(x => x.UserId == id).ToList();
            foreach(var item in data)
            {
                item.Passwords = es.Decrypt(item.Passwords);    
            }
            DGV.DataSource = data;
            DGV.Refresh();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var db = new PassContext();

            string page = WebBox.Text;
            string password = PassBox.Text;

            if(page == null || password == null)
            {
                MessageBox.Show("Empty Fields!");
            }
            Encryption ec = new Encryption();
            string cipher = ec.Encrypt(password);

            Password pass = new Password()
            {
                PasswordsFor = page,
                Passwords = cipher,
                UserId = user.Id
            };

            db.Passwords.Add(pass);
            if(db.SaveChanges()>0)
            {
                MessageBox.Show("Added");
            }
            
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            var db = new PassContext();
            var data = db.Passwords.Where(x => x.UserId == user.Id).ToList();
            DGV.DataSource = data;
            DGV.Refresh();
        }
    }
}
