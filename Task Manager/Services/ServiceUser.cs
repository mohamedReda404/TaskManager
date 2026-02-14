using Microsoft.EntityFrameworkCore;
using Task_Manager.Controllers;
using Task_Manager.Models;
using Task_Manager.Persistence;

namespace Task_Manager.Services
{
    public class ServiceUser : IServiceUser
    {
        private readonly AppDbContext _appDb;

        public ServiceUser(AppDbContext appDb)
        {
            _appDb = appDb;
        }

        public async Task<Users> Add(Users user)
        {
            await _appDb.users.AddAsync(user);
            return user;
        }

        public async Task<bool> Delete(int id)
        {
           var x=await GetById(id);
            if(x is null)
            {
                return false;
            }
            else
            {
                _appDb.users.Remove(x);
                await _appDb.SaveChangesAsync();
                return true;
            }
        }

        public async Task<IEnumerable<Users>> GetAll() 
        {
            var responce= await _appDb.users.ToListAsync();
            return responce;
        }
            
           
        

        public async Task<Users> GetById(int id)=>
           await _appDb.users.FirstOrDefaultAsync(i=>i.Id == id);
        

        public async Task<Users> Update(int id, Users user)
        {
            var x = await GetById(id);
            if (x is null)
            {
                return null;
            }
            else
            {
                x.UserName= user.UserName;
                x.UserPassword= user.UserPassword;
                x.UserEmail= user.UserEmail;
                await _appDb.SaveChangesAsync();
                return x;
            }

        }
    }
}
