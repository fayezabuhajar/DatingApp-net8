using API.Entitie;

namespace API.interfaces;


public interface ITokenService
{
     string CreateToken(AppUser user);
}