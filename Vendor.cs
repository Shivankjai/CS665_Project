using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OfficeDB_CRUD.Models
{
    [Table("Vendor")]
    public class Vendor
    {
        [Key]
        [Column("vendor_id")]
        public int VendorId { get; set; }
        
        [Column("vendor_name")]
        [Required]
        public string VendorName { get; set; }
        
        [Column("vendor_product_type")]
        [Required]
        public string VendorProductType { get; set; }
        
        // Navigation property
        public ICollection<VendorRelation> VendorRelations { get; set; }
    }
}