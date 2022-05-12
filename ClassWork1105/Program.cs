using System;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System.Threading;

namespace ClassWork1105
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account.GetAccounts();
      
            var sum = Account.GetAccounts().Sum(x => x.Amount);
            Task.Run(() => Console.WriteLine($"sum = {sum}"));

            Console.WriteLine();

          
            var name = Account.GetAccounts().Select(x => x.Name);
            foreach (var item in name)
            {
                Task.Run(() => Console.WriteLine(item));
                //   Task.Factory.StartNew(() => Console.WriteLine(item));
            }




         
   
          var days = new List<string> { "sunday", "monday", "tuesday", "wednesday", "thursday", "friday", "saturday" };

            days.OrderBy(x => days);
            foreach (var itm in days)
            {
                
                Console.WriteLine(itm);
            }



            Console.WriteLine();
          
            var month =new List <string> { "jan", "feb", "mar", "apr", "may", "june", "july", "aug", "sept", "oct", "nov", "dec" };
            var months = month.OrderBy(x => x);
           
            foreach (var itm in months)
            {
                Console.WriteLine(itm);
               
          
             
            }
            Console.WriteLine();
            Console.WriteLine();
            month.TakeLast(2);
            var b = months.Reverse().Take(2);
           var o= b.OrderBy(x => x);
            foreach (var itm in o)
            {
                Console.WriteLine(itm);
            }



         




        }

    }


    
  
   
    
      
      

      


    
    





}
