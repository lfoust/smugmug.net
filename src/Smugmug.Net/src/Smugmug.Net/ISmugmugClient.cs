namespace Smugmug
{
    using System.Threading.Tasks;

    public interface ISmugmugClient
    {
        Task<User> GetUserAsync(string nickname);
    }
}
