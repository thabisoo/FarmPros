﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FarmPros.ApplicationLogic.Entities.FarmEntities
{
    public class FarmEntity
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string StreetAddress { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
    }
}
