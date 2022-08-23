using BenimProjem.Business.Helpers;
using BenimProjem.DataAccess.Abstract;
using BenimProjem.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimProjem.Business.Services 
{   
    public class UserService : IUserService
    {
        private readonly IUserDal _userDal;
        private readonly IStringHelper _stringHelper;
        public UserService(IUserDal userDal, IStringHelper stringHelper)
        {
            _userDal = userDal;
            _stringHelper = stringHelper;
        }

        public void Add(User userData)
        {
            _userDal.Add(userData);
        }

        public User AdminLogin(string username, string password)
        {
            password = _stringHelper.ToMd5(password);
            var result = _userDal.Query(x => x.Email == username && x.Password == password && x.IsAdmin == true).FirstOrDefault();
            if (result == null)
            {
                return null;
            }
            else
            {
                return result;
            }
        }

        public void Delete(int id)
        {
            var user = _userDal.Get(x => x.Id == id);
            user.Status = false;
            _userDal.Update(user);
        }

        public User GetById(int userId)
        {
            return _userDal.Get(x => x.Id == userId);
        }

        public List<User> List()
        {
            return _userDal.List(x => x.Status == true);
            // return _userDal.List yapıp yollaya biliriz. null sayılır.
        }

        public User Login(string username, string password)
        {

            password= _stringHelper.ToMd5(password);
            var result = _userDal.Query(x => x.Email == username && x.Password == password).FirstOrDefault();
            if (result == null)
            {
                return null;
            }
            else
            {
                return result;
            }           
        }

        public void Update(User userData)
        {
            _userDal.Update(userData);
        }
    }
}
