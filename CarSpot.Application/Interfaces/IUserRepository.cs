using CarSpot.Domain;

namespace CarSpot.Application.Interfaces;
    public interface IUserRepository 
    {
    Task<IEnumerable<User>> GetAllAsync();
    Task<User?> GetByIdAsync(int id);
    Task<User?> GetByEmailAsync(string email);
    Task AddAsync(User user);
    Task UpdateAsync(User user);
    }