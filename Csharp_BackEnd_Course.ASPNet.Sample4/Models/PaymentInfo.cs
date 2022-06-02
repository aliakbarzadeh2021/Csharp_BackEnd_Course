using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Example5._6._1.Models
{
    public class PaymentInfo
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(80, MinimumLength = 5)]
        public string Name { get; set; }

        [Required]
        [CreditCard]
        public string CardNumber { get; set; }
        
        [Required]
        [Range(1, 12)]
        public int ExpiresMonth { get; set; }

        [Required]
        [Range(2017, 2036)]
        public int ExpiresYear { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}
