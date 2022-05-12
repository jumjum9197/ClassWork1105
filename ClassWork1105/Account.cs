using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork1105
{
    public class Account
    {
        public string Name { get; set; }
        public double Amount { get; set; }
        public char Gender { get; set; }

        public string Yearspecification { get; set; }
        public int Id { get; set; }


    
  
    
        public static List<Account> GetAccounts()
        {
            return new List<Account>()
            {
                new Account { Name = "Amar", Amount = 400_000, Gender ='f', Id = 2, Yearspecification = "2years" },
                new Account { Name = "joe", Amount = 40_000, Gender = 'm', Id = 6, Yearspecification = "2months" },
                new Account { Name = "tola", Amount = 800_000, Gender = 'f', Id = 8, Yearspecification = "5days" },
                new Account { Name = "jude", Amount = 500_000, Gender ='m', Id = 10, Yearspecification = "6years" },
                new Account { Name = "amir", Amount = 1000_000, Gender = 'f', Id = 12, Yearspecification = "1years" },
                new Account { Name = "sam", Amount = 600_000, Gender = 'f', Id = 14, Yearspecification = "1years" },
                new Account { Name = "joy", Amount = 100_000, Gender = 'f', Id = 16, Yearspecification = "3years" },
                new Account { Name = "ola", Amount = 20_000, Gender = 'm', Id = 18, Yearspecification = "4months" },

            };
         


        }
        
    }
}
