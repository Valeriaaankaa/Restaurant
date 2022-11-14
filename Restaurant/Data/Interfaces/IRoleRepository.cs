using Microsoft.AspNetCore.Identity;

namespace Data.Interfaces
{
    public interface IRoleRepository
    {
        IEnumerable<IdentityRole> GetRoles();
    }
}
