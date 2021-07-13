using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using s4lab4v6.ScaffoldModel;


namespace s4lab4v6
{
    class Program
    {
        static void Main(string[] args)
        {
            using var ctx = new NorthwindContext();
            ctx.Add(new OsobyTab() { Id = "2", FirstName = "Michal", LastName = "Kowalski", Address = "Laczna 15", PostCode = "2222" });
            Console.WriteLine(ctx.ChangeTracker.DebugView.LongView);
            //ctx.SaveChanges();
        }
    }
}
