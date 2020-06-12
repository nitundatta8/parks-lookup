using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ParksLookup.Models;

namespace ParksLookup.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController : Controller
  {
    private ParksLookupContext _db;
    public ParksController(ParksLookupContext db)
    {
      _db = db;
    }
    // GET api/parks
    [HttpGet]
    public ActionResult<IEnumerable<Park>> Get()
    {
      return _db.Parks.ToList();
    }
    // POST api/parks
    [HttpPost]
    public void Post([FromBody] Park park)
    {
      _db.Parks.Add(park);
      _db.SaveChanges();
    }
  }
}