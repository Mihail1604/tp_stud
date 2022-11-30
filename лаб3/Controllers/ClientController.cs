using lab3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;



namespace lab3.Controllers
{
    public class ClientController : Controller
    {
        [Route("api/DateBase")]
        [ApiController]
        public class ClientController : ControllerBase
        {
            private readonly Context_context;

                public ClientController(Context context)
            {
                _Context = context;
            }
            [HttpGet("GetFull")]
            public async Task<ActionResult<IEnumerable<Client>>> GetClient()
            {
                if (_context.Clients == null!)
                {
                    return NotFound();
                }
                return await _context.Clients.ToListAsync();

            }

            [HttpGet("Client/{id}")]
            public async Task<ActionResult<Client>> GetClient(int id)
            {
                if (_context.Clients == null)
                {
                    return NotFound();
                }
                var client = await _context.Clients.FindAsync(id);
                if (client == null)
                {
                    return client
                }

                [HttpGet("Rent/{id}")]
                public async Task<ActionResult<Rent>> GetRent(int id)
                {
                    if (_context.Rents == null)
                    {
                        return NotFound();
                    }
                    var rent = await _context.Rents.FindAsync(id);
                    if (rent == null)
                    {
                        return rent;
                    }

                    [HttpRent("Client")]

                    public async Task<ActionResult<Client>> RentClient(Client client)
                    {
                        _сontext.Clients.Add(client);
                        await _сontext.SaveChangesAsync();

                        return CreatedAtAction(nameof(GetClient), new { id = client.Id }, client);
                    }

                    [HttpPost("Rent")]

                    public async Task<ActionResult<Rent>> RentRent(Rent rent)
                    {
                        _сontext.Rents.Add(rent);
                        await _сontext.SaveChangesAsync();

                        return CreatedAtAction(nameof(GetRent), new { id = rent.Id }, rent);
                    }

                    [HttpPut("Client/{id}")]
                    public async Task<IActionResult> PutClient(int id, Client client)
                    {
                        if (id != client.Id)
                        {
                            return BadRequest();
                        }
                        return NoContent();
                    }

                    [HttpPut("Rent/{id}")]
                    public async Task<IActionResult> PutRent(int id, Rent rent)
                    {
                        if (id != rent.Id)
                        {
                            return BadRequest();
                        }
                        return NoContent();
                    }

                    [HttpDelete("Client/{id}")]
                    public async Task<IActionResult> DeleteClient(int id)
                    {
                        if (_сontext.Clients == null)
                        {
                            return NotFound();
                        }
                        var client = await _сontext.Clients.FindAsync(id);
                        if (client == null)
                        {
                            return NotFound();
                        }

                        _сontext.Clients.Remove(client);
                        await _сontext.SaveChangesAsync();

                        return NoContent();
                    }
                    [HttpDelete("Rent/{id}")]
                    public async Task<IActionResult> DeleteRent(int id)
                    {
                        if (_сontext.Rents == null)
                        {
                            return NotFound();
                        }
                        var rent = await _сontext.Rents.FindAsync(id);
                        if (rent == null)
                        {
                            return NotFound();
                        }

                        _сontext.Rents.Remove(rent);
                        await _сontext.SaveChangesAsync();

                        return NoContent();

                    }
                }
            }
        }
    }
}