namespace BuyAPlant.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using BuyAPlant.Data.Common.Models;
    using BuyAPlant.Data.Models.Enum;

    public class Description : BaseDeletableModel<int>
    {
        [Required]
        public TypeEnum Type { get; set; }

        [Required]
        public int MaxGrowthSize { get; set; }

        [Required]
        public GrowingEnum GrowingSpeed { get; set; }

        [Required]
        [Range(-30, 50)]
        public int TemperatureLimit { get; set; }

        [Required]
        public LeafEnum LeafType { get; set; }

        [Required]
        public SunShadeEnum SunShade { get; set; }

        [Required]
        public WateringEnum Watering { get; set; }

        public ConsoleColor Color { get; set; }

        [Required]
        public PlantInfo Info { get; set; }
    }
}
