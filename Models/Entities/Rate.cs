using System.ComponentModel.DataAnnotations;

namespace E_Shop.Models.Entities
{
    public class Rate
    {
        [Display(Name = "Customer Satisfaction Score")]
        public int? CSAT { get; set; }
        public int CompanyRank { get; set; }
        public int AmountOfSales { get; set; }
    }
}
