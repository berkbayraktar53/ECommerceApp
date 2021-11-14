using ECommerceApp.Business.Abstract;
using ECommerceApp.DataAccess.Abstract;
using ECommerceApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public User GetByUser(string email, string password)
        {
            return _userDal.Get(x => x.Email == email && x.Password == password);
        }
    }
}