using System;
using System.Collections.Generic;

#nullable disable

namespace s4lab4v6.ScaffoldModel
{
    public partial class CustomerDemographic
    {
        public CustomerDemographic()
        {
            CustomerCustomerDemos = new HashSet<CustomerCustomerDemo>();
        }

        public string CustomerTypeId { get; set; }
        public string CustomerDesc { get; set; }

        public virtual ICollection<CustomerCustomerDemo> CustomerCustomerDemos { get; set; }
    }
}
