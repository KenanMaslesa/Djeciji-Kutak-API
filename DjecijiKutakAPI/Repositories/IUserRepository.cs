using DjecijiKutakAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DjecijiKutakAPI.Repositories
{
    public interface IUserRepository
    {
        UserDto GetUserByEmail(string email, CancellationToken cancellationToken = default);

    }
}
