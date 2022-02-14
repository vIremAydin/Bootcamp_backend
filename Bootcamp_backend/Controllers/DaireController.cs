using Bootcamp_backend.Data;
using Bootcamp_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bootcamp_backend.Controllers;

public class DaireController : Controller
{
    public readonly AppDbContext db;

    public DaireController(AppDbContext d)
    {
        db = d;
    }
    // GET all daires
    [HttpGet(Name = "GetAllDaires")]
    public IEnumerable<List<Daire>> Get()
    
    {     var lst = db.userInfo.ToList();
        return lst;
    }
    
    
    // GET a user
    [HttpGet(Name = "{id}")]
    public async Task<ActionResult<User>> Get(int id)
    
    {     var lst = db.userInfo.ToList();
        var b =  lst.Find(x => x.Id == id);
        if (b == null)
            return BadRequest("User not found");

        return b;
    }
}