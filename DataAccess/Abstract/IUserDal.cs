
using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
    }
}

//burada aslında sadece tanımladık içini doldurmadık efuserdal
//methoddaki imzaları dahil edebilmem gerek