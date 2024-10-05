using API.Data;
using API.Entitie;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class BuggyController(DataContext context) : BaseApiController
{
[Authorize]
[HttpGet("auth")]
public ActionResult<string> GetAuth()
{
    return "Secret text";
}

[HttpGet("not-found")]
public ActionResult<AppUser> GetNotFound()
{
    var thing = context.Users.Find(-1);

    if(thing == null){
        return NotFound();
    }
    else{
    return thing;
    }
}

[HttpGet("Server-Error")]
public ActionResult<AppUser> GetServerError()
{
    var thing = context.Users.Find(-1) ?? throw new Exception("A bad thing has happened");

    return thing;
}

[HttpGet("bad-request")]
public ActionResult<string> GetBadRequest()
{
    return BadRequest("this was not a good request");
}

}

