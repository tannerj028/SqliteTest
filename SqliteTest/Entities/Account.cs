using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqliteTest.Entities
{
   public class Account
    {
        [AutoIncrement,PrimaryKey]
        public int AccountId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Platform { get; set; }
    }
}
