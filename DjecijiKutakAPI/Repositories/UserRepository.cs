using DjecijiKutakAPI.Data;
using DjecijiKutakAPI.DTOs;
using DjecijiKutakAPI.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DjecijiKutakAPI.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly StoreContext _dbContext;
        private readonly UserManager<User> _userManager;

        public UserRepository(StoreContext dbContext, UserManager<User> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }

        public UserDto GetUserByEmail(string email, CancellationToken cancellationToken = default)
        {
            return _userManager.Users.Where(x => x.Email == email.ToLower()).Select(x => new UserDto(x)).FirstOrDefault();
        }
    }
}
