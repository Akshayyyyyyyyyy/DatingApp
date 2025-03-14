using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;

namespace API.Interfaces
{
    public interface IUserRepository
    {
        Task<AppUser?> GetUserByIdAsync(int id); // Ensure the name is 'GetUserByIdAsync'
        Task<AppUser?> GetUserByUsernameAsync(string username);
        Task<IEnumerable<AppUser>> GetUsersAsync();
        Task<bool> SaveAllAsync();
        void Update(AppUser user);

        Task<IEnumerable<MemberDto>> GetMembersAsync();

        Task<MemberDto?> GetMemberAsync(string username);
    }
}

