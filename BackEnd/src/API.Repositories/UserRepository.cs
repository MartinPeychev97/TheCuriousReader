using API.DataAccess;
using API.DataAccess.Models;
using API.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(DBContext dbContext) : base(dbContext)
        {

        }

        public async Task<IEnumerable<Request>> GetUserRequestAsync(string userId)
        {
            var userRequests = await this.dbContext.Requests
                .Where(r => r.UserId == userId).ToListAsync();

            return userRequests;
        }
    }
}
