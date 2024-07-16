using ShopProSa.Common.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMicroservices.Customers.Domain.Entities
{
    [Table("Customers",Schema ="Sales")]
    public class Customers : BaseEntity<int>
    {
        [Column("custid")]
        public override int Id { get; set; }
        public string companyName { get; set; }
        public string contactTitle {  get; set; }
        public string contactName { get; set; }
        public string Address {  get; set; }
        public string Email { get; set; }
        public string city { get; set; }
        public string? region { get; set; }
        public string? postalCode { get; set; }
        public string country { get; set; }
        public string phone { get; set; }
        public string? fax { get; set; } 

    }
}
