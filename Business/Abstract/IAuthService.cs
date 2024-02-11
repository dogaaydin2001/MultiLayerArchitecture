using Entities.Dtos;

namespace Business.Abstract
{
    public interface IAuthService
    {
        void Register(RegisterAuthDto registerDto);

        string Login(LoginAuthDto loginDto);
    }
}
