using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OfficeDB_CRUD.Models
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        [Column("employees_id")]
        public int EmployeeId { get; set; }
        
        [Column("manager_id")]
        public int? ManagerId { get; set; }
        
        [Column("first_name")]
        [Required]
        public string FirstName { get; set; }
        
        [Column("last_name")]
        [Required]
        public string LastName { get; set; }
        
        [Column("branch_id")]
        public int BranchId { get; set; }
        
        [Column("salary")]
        public int Salary { get; set; }
        
        // Navigation properties
        [ForeignKey("BranchId")]
        public Branch Branch { get; set; }
        
        [ForeignKey("ManagerId")]
        public Employee Manager { get; set; }
        
        public ICollection<Employee> ManagedEmployees { get; set; }
        
        public ICollection<Client> Clients { get; set; }
    }
}