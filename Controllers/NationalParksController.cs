using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NationalParkApi.Models;

namespace NationalParkApi.Controllers
{
  [ApiVersion("1.0")]
  [Route("api/[controller]")]
  [ApiController]
  public class NationalParksController : ControllerBase
  {
    private NationalParkApiContext _db;
    public NationalParksController(NationalParkApiContext db)
    {
      _db = db;
    }
    // GET api/nationalparks
    [HttpGet]
    public ActionResult<IEnumerable<NationalPark>> Get(string region, string name)
    {
      var query = _db.NationalParks.AsQueryable();
      if (region != null)
      {
        query = query.Where(e => e.Region == region);
      }
      if (name != null)
      {
        query = query.Where(e => e.Name == name);
      }
      return query.ToList();
    }
    // POST api/nationalparks
    [HttpPost]
    public void Post([FromBody] NationalPark nationalPark)
    {
      _db.NationalParks.Add(nationalPark);
      _db.SaveChanges();
    }
    // GET api/nationalparks/5
    [HttpGet("{id}")]
    public ActionResult<NationalPark> Get(int id)
    {
        return _db.NationalParks.FirstOrDefault(entry => entry.NationalParkId == id);
    }
    // PUT api/nationalparks/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] NationalPark nationalPark)
    {
        nationalPark.NationalParkId = id;
        _db.Entry(nationalPark).State = EntityState.Modified;
        _db.SaveChanges();
    }
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var nationalParkToDelete = _db.NationalParks.FirstOrDefault(entry => entry.NationalParkId == id);
      _db.NationalParks.Remove(nationalParkToDelete);
      _db.SaveChanges();
    }
  }
}