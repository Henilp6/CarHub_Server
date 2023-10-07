using CarHub_DataAccess;

namespace CarHub_Business.Repository.IRepository
{
    public interface IBookingRepository : IRepository<Booking>
    {
        Task<Booking> UpdateAsync(Booking entity);
    }
}
