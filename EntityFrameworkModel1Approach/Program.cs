using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkModel1Approach
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var con = new Model1Container())
            {
                var cc = new List<Customer>()
                {
                    new Customer{cname = "paul", cage="dd"},
                     new Customer{cname = "john", cage="ff"},
                      new Customer{cname = "paul", cage="kk"},
                };
                con.Customers.AddRange(cc); //to insert data
                con.SaveChanges();
                //to getdata
                var res = con.Customers.ToList();
                Console.WriteLine();
                foreach(var i in res)
                {
                    Console.WriteLine("customer id" + i.Id);
                    Console.WriteLine("customer name" + i.cname);
                    Console.WriteLine("customer age" + i.cage);

                }
                Console.WriteLine("worked");
                Console.ReadKey();


                /*output = customer id1
customer namepaul
customer agedd
customer id2
customer namejohn
customer ageff
customer id3
customer namepaul
customer agekk
worked
*/

            }
        }
    }
}
