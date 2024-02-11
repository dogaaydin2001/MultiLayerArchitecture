using Business.Abstract;
using Core.Utilities;
using Entities.Dtos;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private readonly IUserService _userService;

        public AuthManager(IUserService userService)
        {
            _userService = userService;
        }

        public string Login(LoginAuthDto loginDto)
        {
           var user = _userService.GetByMail(loginDto.Email);
            var result = HashingHelper.VerifyPasswordHash(loginDto.Password, user.PasswordHash, user.PasswordSalt);
            if (result)
            {
                return ("Kullanıcı girişi başarılı");
            }
            return ("Kullanıcı girişi başarısız");
        }

        public void Register(RegisterAuthDto registerDto)
        {
            _userService.Add(registerDto);
        }
    }
}
