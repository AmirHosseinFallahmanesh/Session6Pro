using Microsoft.EntityFrameworkCore;

namespace EndPoint
{
    public class User
    {
        public int UserId { get; set; }
        public string LastName { get; set; }
  
        public Book WriteBy { get; set; }
        public Book EditBy { get; set; }


    }

    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }

        public Address Address { get; set; }

    }

    //[Owned]
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
    }
}