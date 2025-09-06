
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RealSite.DBProvider.Model
{
    [Table("banks_list")]
    public class Bank
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Bank name is required")]
        [MaxLength(500, ErrorMessage = "Bank name should not exceed 500 characters")]
        [Column("bank_name")]
        public string BankName { get; set; } = string.Empty;

        [Column("bank_created_by")]
        public int? BankCreatedBy { get; set; }
    }
}
