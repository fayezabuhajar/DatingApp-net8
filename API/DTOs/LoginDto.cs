namespace API.DTOs;
using System.ComponentModel.DataAnnotations;


public class LoginDto{
    
     
public required string Username { get; set; }


public required string Password {get; set;}
}