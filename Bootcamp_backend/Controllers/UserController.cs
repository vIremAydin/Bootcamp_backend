using Bootcamp_backend.Data;
using Bootcamp_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bootcamp_backend.Controllers;

public class UserController : Controller
{
    
    
    public readonly AppDbContext db;

    public UserController(AppDbContext d)
    {
        db = d;
    }
    // GET all users
    [HttpGet(Name = "GetAllUsers")]
    public IEnumerable<List<User>> Get()
    
    {     var lst = db.daireInfo.ToList();
         return lst;
    }
    
    
    // GET a user
    [HttpGet(Name = "{no}")]
    public async Task<ActionResult<User>> Get(int no)
    
    {     var lst = db.daireInfo.ToList();
        var b =  lst.Find(x => x.no == no);
        if (b == null)
            return BadRequest("User not found");

        return b;
    }
    
    
    [HttpPost]
    public async Task<ActionResult<List<User>>> addDaire(Daire daire)
    {
        // Users.Add(User);
        //return Users;

        db.daireInfo.Add(daire);
        db.SaveChanges();
        return db.daireInfo.ToList();
    }

    [HttpPut]
    public async Task<ActionResult<List<Daire>>> updateDaire(Daire daire)
    {
      
        var d = db.daireInfo.FirstOrDefault(itm => itm.no == daire.no);
        if(User == null)
            return NotFound();
        d = daire;
        db.SaveChanges();
        return db.daireInfo.ToList();
    }

    [HttpDelete]
    public async Task<ActionResult<List<User>>> deleteDaire(Daire daire)
    {
        var f = db.daireInfo.FirstOrDefault(b => b.no == daire.no); 
        if (f == null)
            return BadRequest("User not found");
        
        db.Remove(f);
        db.SaveChanges();
        return db.daireInfo.ToList();
    }
}