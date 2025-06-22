

using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace YourApp.Models

{

    [Table("Species")]

    [PrimaryKey(nameof(LatinName))]

    public class Species

    {
        public int SpeciesId { get; set; }
        public string LatinName { get; set; }

        public int GrowthTimeInYears { get; set; }
        

        public ICollection<Batch> Batches { get; set; }

    }

}
