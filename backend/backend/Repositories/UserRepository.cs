using backend.Repositories.Interfaces;

namespace backend.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly List<KeyValuePair<int, string>> _usersList;

        public UserRepository()
        {
            _usersList = new List<KeyValuePair<int, string>>()
            {
                new(1, "Lucas Santos"),
                new(2, "Maria Rodrigues"),
                new(3, "Mateus Almeida")
            };
        }

        public KeyValuePair<int, string> FindUser(int id)
        {
            KeyValuePair<int, string> user = _usersList.FirstOrDefault(x => x.Key == id);
            return user;
        }
    }
}
