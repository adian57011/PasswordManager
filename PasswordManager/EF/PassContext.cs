using PasswordManager.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.EF
{
    public class PassContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Password> Passwords { get; set; }
    }
}
