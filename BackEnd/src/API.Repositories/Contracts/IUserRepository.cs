using API.DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Repositories.Contracts
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<IEnumerable<Request>> GetUserRequestAsync(string userName);
    }
}
