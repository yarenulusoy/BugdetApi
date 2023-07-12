using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Data;
using WebApplication3.Model;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionController : ControllerBase


    {
        private DatabaseContext _databaseContext;
        public TransactionController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;

        }


        [HttpPost]
        public async Task<IActionResult> Post(Transactions transaction)
        {
            _databaseContext.Transactions.Add(transaction);
            await _databaseContext.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var transactions = await _databaseContext.Transactions.ToListAsync();
            if (transactions == null || transactions.Count == 0)
            {
                return NotFound();
            }

            return Ok(transactions);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var transaction = await _databaseContext.Transactions.FindAsync(id);
            if (transaction == null)
            {
                return NotFound();
            }
            _databaseContext.Transactions.Remove(transaction);
            await _databaseContext.SaveChangesAsync();
            return NoContent();
        }
    } }