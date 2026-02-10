

namespace Task_Manager.Models
{
    public class Users
    {
       
       
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string UserEmail { get; set; }= string.Empty;
        public string UserPassword { get; set; }=string.Empty;



        //===========Realtionships(1:M)
        public List<Tasks>? tasks { get; set; }

    }
}
