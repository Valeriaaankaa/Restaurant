using Microsoft.AspNetCore.Identity;

namespace Data.Interfaces
{
    public interface IRoleRepository
    {
        ICollection<IdentityRole> GetRoles();
    }
}
