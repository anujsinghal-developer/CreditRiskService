using CreditRiskService.Models;
using CreditRiskService.Models.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreditRiskService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CreditLimitController : ControllerBase
    {
        private readonly CreditRiskServiceContext _context;
        public CreditLimitController(CreditRiskServiceContext context)
        {
            _context = context;
        }

        [HttpGet(Name = nameof(GetBankCreditLimits))]
        [ProducesResponseType(200)]
        public async Task<ActionResult<IEnumerable<BankCreditLimit>>> GetBankCreditLimits()
        {
            string StoredProc = "exec uspGetApprovedBankLimits @businessDate = '20210809' ";
            
            return await _context.BankCreditLimits.FromSqlRaw(StoredProc).ToListAsync();
        }
    }
}
