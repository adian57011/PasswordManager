using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.EF.Models
{
    public class Password
    {
        public int Id { get; set; }
        public string PasswordsFor { get; set; }
        public string Passwords { get; set; }
        
        [ForeignKey("Users")]
        public int UserId { get; set; }

        public virtual User Users { get; set; }
    }
}
