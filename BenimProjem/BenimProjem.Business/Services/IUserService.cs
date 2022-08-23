using BenimProjem.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimProjem.Business.Services
{
    public interface IUserService
    {
        User Login(string username, string password);
        User AdminLogin(string username, string password);//boll adminLogin eklenecek mi?
        User GetById(int userId);
        List<User> List();

        void Delete(int id);
        void Add(User userData);
        void Update(User userData);

    }
}
