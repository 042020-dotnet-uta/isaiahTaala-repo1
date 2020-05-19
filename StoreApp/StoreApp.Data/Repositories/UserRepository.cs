using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StoreApp.BusinessLogic;

namespace StoreApp.Data.Repositories
{
    public class UserRepository : IRepository<BusinessLogic.User>
    {
        private readonly StoreAppDbContext _context;

        public UserRepository(StoreAppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(BusinessLogic.User user)
        {
            if (_context.Users.Any(u => u.Email == user.Email))
            {
                throw new Exception("User already exists");
            }

            var dataUser = new User()
            {
                UserID = user.UserID,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Password = user.Password
            };

            _context.Add(dataUser);
            await _context.SaveChangesAsync();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BusinessLogic.User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<BusinessLogic.User> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<BusinessLogic.User> GetAsync(BusinessLogic.User user)
        {
            var dbuser = await _context.Users.SingleAsync(u => u.Email == user.Email && u.Password == user.Password );
            if (dbuser == null)
                throw new Exception("Email or password incorrect");

            return new BusinessLogic.User
            {
                Email = dbuser.Email,
                FirstName = dbuser.FirstName,
                LastName = dbuser.LastName
            };
        }
    }
}
