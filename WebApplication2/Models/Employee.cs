

using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace YourApp.Models

{

    [Table("Employees")]

    [PrimaryKey(nameof(EmployeeId))]

    public class Employee

    {

        public int EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

      

        public ICollection<BatchEmployee> BatchEmployees { get; set; }

    }

}