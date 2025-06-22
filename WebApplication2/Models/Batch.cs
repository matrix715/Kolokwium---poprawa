

using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace YourApp.Models

{

    [Table("Batches")]

    [PrimaryKey(nameof(BatchId))]

    public class Batch

    {

        public int BatchId { get; set; }

        public int Quantity { get; set; }

        public DateTime SownDate { get; set; }

        public DateTime ReadyDate { get; set; }

        
        public string SpeciesLatinName { get; set; }

        [ForeignKey(nameof(SpeciesLatinName))]

        public Species Species { get; set; }
        

        public int NurseryId { get; set; }

        [ForeignKey(nameof(NurseryId))]

        public Nursery Nursery { get; set; }
        
        public ICollection<BatchEmployee> BatchEmployees { get; set; }

    }

}