using BuyAPlant.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuyAPlant.Data.Models
{
    public class Image : BaseDeletableModel<int>
    {
        public string ImageUrl { get; set; }
    }
}
