using Backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Service
{
    public interface IUserService
    {
        void Add(User user);
        User Get(int id);
        List<User> GetAll();
        void Update(User user);
        void Delete(int id);
    }
}
