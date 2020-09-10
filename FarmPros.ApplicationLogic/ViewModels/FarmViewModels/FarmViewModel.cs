using FarmPros.ApplicationLogic.ViewModels.AddressViewModels;
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

        public AddressViewModel Address { get; set; }
    }
}
