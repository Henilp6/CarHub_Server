﻿using CarHub_Business.Repository.IRepository;
using CarHub_DataAccess;
using CarHub_DataAccess.Data;

namespace CarHub_Business.Repository
{
    public class ReviewXCommentRepository : Repository<ReviewXComment>, IReviewXCommentRepository
    {
        private readonly ApplicationDbContext _db;
        public ReviewXCommentRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public async Task<ReviewXComment> UpdateAsync(ReviewXComment entity)
        {
            
            _db.ReviewXComments.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
