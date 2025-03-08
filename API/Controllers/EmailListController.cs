using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class EmailListController(DataContext context) : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmailList>>> GetEmailList()
        {
            var emails = await context.Emails.ToListAsync();

            return emails;
        }
    }
}
