using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieRental.Models;

namespace MovieRental.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MemebershipTypes { get; set; }
        public Customer Customer { get; set; }

    }
}