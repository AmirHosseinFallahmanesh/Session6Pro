using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EndPoint
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }

        [InverseProperty("WriteBy")]
        public List<User> Writers { get; set; }


        [InverseProperty("EditBy")]
        public List<User> Editors { get; set; }
    }
}