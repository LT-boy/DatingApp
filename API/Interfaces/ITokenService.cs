using API.Entities;

namespace API.Interfaces
{
    public interface ITokenService
    {
        //return string, call method CreateToken, pass in argument AppUser and call it user
        string CreateToken(AppUser user);
    }
}