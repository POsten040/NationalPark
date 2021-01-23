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
  public class StateParksController : ControllerBase
  {
    private NationalParkApiContext _db;
    public StateParksController(NationalParkApiContext db)
    {
      _db = db;
    }
    // GET api/Stateparks
    [HttpGet]
    public ActionResult<IEnumerable<StatePark>> Get(string name)
    {
      var query = _db.StateParks.AsQueryable();
      if (name != null)
      {
        query = query.Where(e => e.Name == name);
      }
      return query.ToList();
    }
    // POST api/Stateparks
    [HttpPost]
    public void Post([FromBody] StatePark statePark)
    {
      _db.StateParks.Add(statePark);
      _db.SaveChanges();
    }
    // GET api/Stateparks/5
    [HttpGet("{id}")]
    public ActionResult<StatePark> Get(int id)
    {
        return _db.StateParks.FirstOrDefault(entry => entry.StateParkId == id);
    }
    // PUT api/Stateparks/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] StatePark statePark)
    {
        statePark.StateParkId = id;
        _db.Entry(statePark).State = EntityState.Modified;
        _db.SaveChanges();
    }
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var StateParkToDelete = _db.StateParks.FirstOrDefault(entry => entry.StateParkId == id);
      _db.StateParks.Remove(StateParkToDelete);
      _db.SaveChanges();
    }
  }
}