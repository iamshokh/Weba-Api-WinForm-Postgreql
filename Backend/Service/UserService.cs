using Backend.DataLayer;
using Backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Service
{
    public class UserService : IUserService
    {
        private readonly EfCoreContext _context;
        public UserService(EfCoreContext context)
        {
            _context = context;
        }
        public void Add(User user)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            var result = _context.Users.ToList();
            return result;
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
