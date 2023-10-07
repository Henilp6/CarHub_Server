
using CarHub_DataAccess;

namespace CarHub_Business.Repository.IRepository
{
    public interface IReviewRepository : IRepository<Review>
    {
        Task<Review> UpdateAsync(Review entity);
    }
}
