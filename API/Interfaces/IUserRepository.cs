using API.Data;
using API.DTOs;
using API.Entitie;

namespace API.interfaces;

public interface IUserRepository 
{
    void Update(AppUser user);

    Task<bool> SaveAllAsync();
    Task<IEnumerable<AppUser>> GetUsersAsync();
    Task<AppUser?> GetUserByIdAsync(int id);
    Task<AppUser?> GetUserByUsernameAsync(string username);
    Task<IEnumerable<MemberDto>> GetMemberAsync();
    Task<MemberDto?> GetMemberAsync(string username);
}
