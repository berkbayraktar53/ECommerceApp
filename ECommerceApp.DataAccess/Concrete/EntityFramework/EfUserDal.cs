using ECommerceApp.Core.DataAccess.Concrete.EntityFramework;
using ECommerceApp.DataAccess.Abstract;
using ECommerceApp.DataAccess.Concrete.EntityFramework.Contexts;
using ECommerceApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, ECommerceContext>, IUserDal
    {

    }
}