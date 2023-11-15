using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Alfakhouri.Models.DBEntites
{
    public class Items
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ItemNo { get; set; }
        [Column(TypeName="varchar(50)")]
        public string? AName { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? EName { get; set; }
        public double Price { get; set; }
        public DateTime ItemDate { get; set; }
        [ForeignKey("Units")]
        public int UnitId { get; set; }
        public Units? Units { get; set; }
        [ForeignKey("Stores")]
        public int StoreId { get; set; }
        public Stores? Stores { get; set; }
        public int Qty { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? Description { get; set; }
    }
}
