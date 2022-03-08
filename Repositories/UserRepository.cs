using DataTransferObjectIntro.Entities;

namespace DataTransferObjectIntro.Repositories
{
    public class UserRepository : IUserRepository
    {
        public async Task<IEnumerable<User>> GetAllAsync()
        {
            // Mocking a database async call
            var users = new List<User>
            {
                new User(1, "Talles Valiatti", "5529 9327 5827 3150"),
                new User(2, "Jane Claudia Valiatti", "5434 3504 4973 0815"),
                new User(3, "Rogerio Valiatti", "5328 1780 6220 3813"),
            };

            return await Task.FromResult(users);
        }
    }
}