using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;
using System.Text;

namespace FarmPros.ApplicationLogic.ViewModels.FarmViewModels
{
    public class FarmViewModel
    {
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Enter Your Farm Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }

        [Required]
        public string Surburb { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Province { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }
    }
}
