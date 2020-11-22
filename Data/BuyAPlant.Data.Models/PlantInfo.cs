namespace BuyAPlant.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using BuyAPlant.Data.Common.Models;

    public class PlantInfo : BaseDeletableModel<int>
    {
        [Required]
        public string Info { get; set; }
    }
}
