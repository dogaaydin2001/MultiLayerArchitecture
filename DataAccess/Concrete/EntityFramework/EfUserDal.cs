using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, SimpleContextDb>, IUserDal
    {
    } 
}

//Classı clasa dahil ettiğimde tüm her şeyi kullanmak zorunda değiliöm
//ama interfacce kullanırken tüm her şeyi kullanmam gerek
//classlar bir yapının içerisinde çağırılabilmesi için new'lenmesi gerekir