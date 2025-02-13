﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMicroservices.Customers.Application.DTO
{
    public class CustomerGetAll
    {
        public int custiId { get; set; }
        public string companyName { get; set; }
        public string contactTitle { get; set; }
        public string contactName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string email { get; set; }
        public string? region { get; set; }
        public string? postalCode { get; set; }
        public string country { get; set; }
        public string Phone { get; set; }
        public string? fax { get; set; }
    }
}
