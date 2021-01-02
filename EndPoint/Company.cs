using System.Collections.Generic;

namespace EndPoint
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
