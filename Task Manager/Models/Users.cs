

namespace Task_Manager.Models
{
    public class Users
    {
       
        [Key]
        public int UserId { get; set; }
        [Required,MaxLength(100)]
        public string UserName { get; set; } = string.Empty;
        [Required]
        public string UserEmail { get; set; }= string.Empty;
        [Required]
        public string UserPassword { get; set; }=string.Empty;



        //===========Realtionships(1:M)
        public List<Tasks>? tasks { get; set; }

    }
}
