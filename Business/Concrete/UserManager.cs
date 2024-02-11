using Business.Abstract;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(AuthDto authDto)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePassword(authDto.Password, out passwordHash, out passwordSalt);

            User user = new User(); // User nesnesi oluşturuldu (Entity'den gelir ve veritabanı tablosu ile eşleşir )
            user.Id = 0;
            user.Email = authDto.Email;
            user.Name = authDto.Name;   
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;
            user.ImageUrl = authDto.ImageUrl;

        }

        public List<User> GetList()
        {
            return _userDal.GetAll();
        }
    }
}
