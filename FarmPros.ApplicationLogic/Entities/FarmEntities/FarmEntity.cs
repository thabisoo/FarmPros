using FarmPros.ApplicationLogic.Entities.AddressEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarmPros.ApplicationLogic.Entities.FarmEntities
{
    public class FarmEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public AddressEntity Address { get; set; }
    }
}
