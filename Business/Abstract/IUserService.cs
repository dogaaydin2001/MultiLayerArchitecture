using Entities.Concrete;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface IUserService
    {
        void Add(AuthDto authDto);
        List<User> GetList();
    }
}
