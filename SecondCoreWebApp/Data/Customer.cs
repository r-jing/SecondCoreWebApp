using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SecondCoreWebApp.Data
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Customer name is required"), StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Customer email is required"), StringLength(500)]
        public string Email { get; set; }
    }
}
