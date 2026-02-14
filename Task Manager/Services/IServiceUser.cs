using Task_Manager.Controllers;
using Task_Manager.Models;

namespace Task_Manager.Services
{
    public interface IServiceUser
    {
        Task<IEnumerable<Users>> GetAll();
        Task<Users> GetById(int id);
        Task<bool> Delete(int id);
        Task<Users> Update(int id, Users user);
        Task<Users> Add(Users user);
    }
}
