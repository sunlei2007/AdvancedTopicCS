using Lab5.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Lab5.Models
{
    public class BankAccount
    {
        
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required(ErrorMessage = "Balance is required.")]
        [Range(0, 999999999, ErrorMessage = "Balance should be between 0 and 999,999,999.")]
        public decimal Balance { get;set; }

        public string UserID { get; set; }
        public Lab5User Lab5User { get; set; } = default!;


    }
}
