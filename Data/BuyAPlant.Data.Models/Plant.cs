namespace BuyAPlant.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using BuyAPlant.Data.Common.Models;
    using BuyAPlant.Data.Models.Enum;

    public class Plant : BaseDeletableModel<int>
    {
        public Plant()
        {
            this.Images = new HashSet<Image>();
            this.Reviews = new HashSet<Review>();
        }

        [Required]
        public string CommonName { get; set; }

        [Required]
        public string ScientificName { get; set; }

        [Range(0, 5)]
        public int Rank { get; set; }

        [Required]
        public bool Stock { get; set; } = true;

        public PlantInfo Info { get; set; }

        [Required]
        public string ProductCode { get; set; }

        [Required]
        [Range(0.0, double.MaxValue, ErrorMessage = "The field {0} must be greater than {1}.")]
        public decimal Price { get; set; }

        public DateTime AddDate { get; set; }

        public ContainerEnum Container { get; set; }

        public int DescriptionId { get; set; }

        public Description Description { get; set; }

        public ICollection<Review> Reviews { get; set; }

        public ICollection<Image> Images { get; set; }
    }
}
