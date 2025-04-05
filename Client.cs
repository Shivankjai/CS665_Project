using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OfficeDB_CRUD.Models
{
    [Table("Clients")]
    public class Client
    {
        [Key]
        [Column("client_id")]
        public int ClientId { get; set; }
        
        [Column("company_name")]
        [Required]
        public string CompanyName { get; set; }
        
        [Column("client_email_id")]
        [Required]
        [StringLength(100)]
        public string ClientEmailId { get; set; }
        
        [Column("employee_id")]
        public int EmployeeId { get; set; }
        
        // Navigation property
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }
}
