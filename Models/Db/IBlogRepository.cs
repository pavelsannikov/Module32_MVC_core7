namespace Module32_MVC_core7.Models.Db
{
    public interface IBlogRepository
    {
        Task<User[]> GetUsers();
        Task AddUser(User user);
    }
}
