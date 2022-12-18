using System;
using API.Entities;

namespace API.Interfaces
{

    public interface ITokenService
    {
        System.Threading.Tasks.Task<string> CreateToken(AppUser user);

    
    }


}