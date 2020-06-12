using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParksLookup.Models;
using System;

namespace ParksLookup.Controllers
{
  [ApiVersion("1.0")]
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

    // GET api/parks/3
    [HttpGet("{id}")]
    public ActionResult<Park> Get(int id)
    {
      return _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
    }

    // GET api/parks/search?state=Oregon&name=Painted Hills
    [HttpGet("search")]
    public ActionResult<IEnumerable<Park>> Search(string name, string state)
    {
      var query = _db.Parks.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (state != null)
      {
        query = query.Where(entry => entry.State == state);
      }

      return query.ToList();
    }

    // PUT api/parks/3
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Park park)
    {
      park.ParkId = id;
      _db.Entry(park).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/parks/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var parkToDelete = _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
      _db.Parks.Remove(parkToDelete);
      _db.SaveChanges();
    }
    // // GET api/parks/random

    // [HttpGet("random")]
    // public ActionResult<Park> Random()
    // {
    //   List<Park> parks = _db.Parks.ToList();
    //   var rnd = new Random();
    //   int rndIdx = rnd.Next(0, parks.Count);
    //   return parks[rndIdx];
    // }
  }

  //versioning V2
  [ApiVersion("2.0")]
  [Route("api/[controller]")]
  [ApiController]
  public class ParksV2 : Controller
  {
    private ParksLookupContext _db;
    public ParksV2(ParksLookupContext db)
    {
      _db = db;
    }
    // GET api/parks/random

    [HttpGet("random")]
    public ActionResult<Park> Random()
    {
      List<Park> parks = _db.Parks.ToList();
      var rnd = new Random();
      int rndIdx = rnd.Next(0, parks.Count);
      return parks[rndIdx];
    }
  }
}