

using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace YourApp.Models

{

    [Table("BatchEmployees")]

    [PrimaryKey(nameof(BatchId), nameof(EmployeeId))]

    public class BatchEmployee

    {
        public int BatchId { get; set; }

        [ForeignKey(nameof(BatchId))]

        public Batch Batch { get; set; }
        
        public int EmployeeId { get; set; }

        [ForeignKey(nameof(EmployeeId))]

        public Employee Employee { get; set; }

        public string Role { get; set; }

    }

}