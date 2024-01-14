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
    public class EfUserDal : IUserDal
    {
        public void Add(User user)
        {
            using (var context = new SimpleContextDb())
            { context.Users.Add(user);
                context.SaveChanges();
            }
        }

        public void Delete(User user)
        {
            using (var context = new SimpleContextDb())
            {
                context.Users.Remove(user);
                context.SaveChanges();
            }
        }

        public User Get(int id)
        {
        using (var context = new SimpleContextDb())
            {
                return context.Users.Where(p=> p.Id == id).FirstOrDefault();
            }
        }

        public List<User> GetAll()
        {
            using (var context = new SimpleContextDb())
            {
                return context.Users.ToList();
            }
        }

        public void Update(User user)
        {
            using (var context = new SimpleContextDb())
            {
                context.Users.Update(user);
                context.SaveChanges();
            }
        }
    }
}

//Classı clasa dahil ettiğimde tüm her şeyi kullanmak zorunda değiliöm
//ama interfacce kullanırken tüm her şeyi kullanmam gerek
//classlar bir yapının içerisinde çağırılabilmesi için new'lenmesi gerekir