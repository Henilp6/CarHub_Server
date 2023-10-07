using CarHub_DataAccess;

namespace CarHub_Business.Repository.IRepository
{
    public interface IReviewXCommentRepository : IRepository<ReviewXComment>
    {
        Task<ReviewXComment> UpdateAsync(ReviewXComment entity);
    }
}
