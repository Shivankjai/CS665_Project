using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OfficeDB_CRUD.Models
{
    [Table("OfficeBranches")]
    public class Branch
    {
        [Key]
        [Column("branch_id")]
        public int BranchId { get; set; }
        
        [Column("country_name")]
        [Required]
        public string CountryName { get; set; }
        
        [Column("branch_founder_name")]
        [Required]
        public string BranchFounderName { get; set; }
        
        [Column("branch_name")]
        [Required]
        public string BranchName { get; set; }
        
        // Navigation properties
        public ICollection<Employee> Employees { get; set; }
        public ICollection<VendorRelation> VendorRelations { get; set; }
    }
}
