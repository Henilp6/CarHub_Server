﻿using CarHub_Business.Repository.IRepository;
using CarHub_DataAccess;
using CarHub_DataAccess.Data;

namespace CarHub_Business.Repository
{
    public class DealerRepository : Repository<Dealer>, IDealerRepository
    {
        private readonly ApplicationDbContext _db;
        public DealerRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public async Task<Dealer> UpdateAsync(Dealer entity)
        {
            
            _db.Dealers.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
