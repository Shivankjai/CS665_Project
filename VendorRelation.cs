
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OfficeDB_CRUD.Models
{
    [Table("VendorRelation")]
    public class VendorRelation
    {
        [Column("branch_id")]
        public int BranchId { get; set; }
        
        [Column("vendor_id")]
        public int VendorId { get; set; }
        
        // Navigation properties
        [ForeignKey("BranchId")]
        public Branch Branch { get; set; }
        
        [ForeignKey("VendorId")]
        public Vendor Vendor { get; set; }
    }
}