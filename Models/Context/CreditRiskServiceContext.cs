using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreditRiskService.Models.Context
{
    public class CreditRiskServiceContext: DbContext
    {
       

        public CreditRiskServiceContext(DbContextOptions<CreditRiskServiceContext> options): base(options)
        { }

        public DbSet<BankCreditLimit> BankCreditLimits { get; set; }
    }
}
