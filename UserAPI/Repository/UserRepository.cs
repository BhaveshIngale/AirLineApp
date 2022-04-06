using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserAPI.DBContext;
using UserAPI.Models;

namespace UserAPI.Repository
{
    public class UserRepository:IUserRepository
    {
        private readonly UserDBContext _context;
        public UserRepository(UserDBContext context)
        {
            _context = context;
        }
        public bool AddNewUser(User model)
        {
            try
            {
                _context.users.Add(model);
                _context.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
        private bool CheckUser(User model)
        {
            return _context.users.Any(x => x.Name == model.Name);
        }
        public List<User> GetAllUsers()
        {
            return _context.users.ToList();
        }

        public bool UserLogin(string email, string password)
        {
            try
            {
                return _context.users.Any(x => x.Email == email && x.Password == password);
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
