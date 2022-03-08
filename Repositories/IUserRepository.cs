using DataTransferObjectIntro.Entities;

namespace DataTransferObjectIntro.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllAsync();
    }
}