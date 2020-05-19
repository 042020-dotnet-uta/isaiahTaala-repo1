using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StoreApp.BusinessLogic;

namespace StoreApp.Data
{
    public class LocationRepository : IRepository<BusinessLogic.Location>
    {
        private readonly StoreAppDbContext _context;

        public LocationRepository(StoreAppDbContext context)
        {
            _context = context;
        }

        public Task AddAsync(BusinessLogic.Location location)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<BusinessLogic.Location>> GetAllAsync()
        {
            var locations = await _context.Locations.ToListAsync();
            return locations.Select(l => new BusinessLogic.Location
            {
                LocationID = l.LocationID,
                Address = l.Address,
                City = l.City,
                State = l.State
            });
        }

        public Task<BusinessLogic.Location> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BusinessLogic.Location> GetAsync(BusinessLogic.Location location)
        {
            throw new NotImplementedException();
        }
    }
}
