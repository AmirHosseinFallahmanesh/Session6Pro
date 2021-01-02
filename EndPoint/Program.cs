using System;

namespace EndPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            MyContext ctx = new MyContext();
            //ctx.Database.EnsureDeleted();
            //ctx.Database.EnsureCreated();

            ctx.Orders.Add(new Order()
            {
                CustomerName = "amiri",
                Address = new Address()
                {
                    City = "Tehran",
                    Street = "Vanak"
                }

            });
            ctx.SaveChanges(); ;

    
            Console.WriteLine("Done!!!!");

        }

        private static void Generate01(MyContext ctx)
        {
          
            ctx.Companies.Add(new Company()
            {
                Name = "AliComapny",
                Employees = new System.Collections.Generic.List<Employee>()
            {
                new Employee()
                {
                    Name="reza"
                }
            }

            });
            ctx.SaveChanges();
        }
    }
}
