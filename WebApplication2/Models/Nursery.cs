

using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace YourApp.Models

{

    [Table("Nurseries")]

    [PrimaryKey(nameof(NurseryId))]

    public class Nursery

    {

        public int NurseryId { get; set; }

        public string Name { get; set; }

        public DateOnly EstablishedDate { get; set; }
        
        public ICollection<Batch> Batches { get; set; }

    }

}