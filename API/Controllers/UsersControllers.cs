using System.Collections.Generic;
using API.Controllers;
using API.Data;
using API.DTOs;
using API.Entitie;
using API.interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



[Authorize]
public class UsersController(IUserRepository userRepository) : BaseApiController
{

[HttpGet]
public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers()
{
    var users = await userRepository.GetMemberAsync();
    return Ok(users);
}

[HttpGet("{username}")]
public async Task<ActionResult<MemberDto>> GetUser(string username)
{
var user = await userRepository.GetMemberAsync(username);


if(user == null) return NotFound();

return user;
}

}
