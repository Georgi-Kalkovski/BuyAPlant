using BuyAPlant.Data.Common.Models;

namespace BuyAPlant.Data.Models
{
    public class Review : BaseDeletableModel<int>
    {
        public string Comment { get; set; }
    }
}
