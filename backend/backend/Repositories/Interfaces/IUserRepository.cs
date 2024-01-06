using backend.Models;

namespace backend.Repositories.Interfaces
{
    public interface IUserRepository
    {
        public KeyValuePair<int, string> FindUser(int id);
    }
}
