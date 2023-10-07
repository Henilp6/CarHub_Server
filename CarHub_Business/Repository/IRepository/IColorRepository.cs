
using CarHub_DataAccess;

namespace CarHub_Business.Repository.IRepository
{
    public interface IColorRepository : IRepository<Color>
    {
        Task<Color> UpdateAsync(Color entity);
    }
}
