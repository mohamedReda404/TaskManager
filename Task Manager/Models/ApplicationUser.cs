using Microsoft.AspNetCore.Identity;

namespace Task_Manager.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string FirstName {  get; set; }=string.Empty;
        public string LastName { get; set; } = string.Empty;
    }
}
