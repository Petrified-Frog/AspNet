using System;
using System.Collections.Generic;

#nullable disable

namespace Uppgift2.Server.Entities
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
