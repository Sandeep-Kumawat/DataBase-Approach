using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    class Program
    {
        static void Main(string[] args)
        {
           DB1stApproachEntities context = new DB1stApproachEntities();
            
            var pro = context.Product_Detail.Include("Products");
            pro.ToList().ForEach(
                (i) => {
                    Console.WriteLine(i.Owner);
                }
                );
        }
    }
}
