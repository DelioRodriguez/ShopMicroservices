using System.ComponentModel.DataAnnotations.Schema;
using ShopMicroservices.Categories.Domain.Interfaces;
using ShopProSa.Common.Data.Base;

namespace ShopMicroservices.Categories.Domain.Entities
{
    [Table("Categories",Schema = "Production")]
    public class Categories : AuditEntity<int>
    {
        [Column("categoryid")]
        public override int Id { get; set; }
    
        public string categoryName { get; set; }
    
        public string description { get; set; }
    }
}