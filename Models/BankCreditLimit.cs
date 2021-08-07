using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreditRiskService.Models
{
    [Keyless]
    public class BankCreditLimit
    {
        public DateTime BusinessDate { get; set; }
        public string BankName { get; set; }
        
        public int? Rating { get; set; }
        public decimal? TotalAssets { get; set; }
        public decimal? CalculatedLimit { get; set; }

    }
}
