using ExpenseTracker.Model;

namespace ExpenseTracker.Repository
{
    public interface IUser
    {
          
        Task<IEnumerable<User>> GetAllAsync();
        Task<User> GetByIdAsync(string id);
        Task<User> AddAsync(User user);
        Task<User> UpdateAsync(User user);
        Task DeleteAsync(string id);
    }
}

