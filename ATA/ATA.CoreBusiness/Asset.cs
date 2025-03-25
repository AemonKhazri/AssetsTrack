using System.ComponentModel.DataAnnotations;

namespace ATA.CoreBusiness
{
    public class Asset
    {


        public int AssetId { get; set; }
        [Required]
        public string? AssetName { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }

    }
}
