

namespace Task_Manager.Models
{
    public class Tasks
    {
       
        public int  Id { get; set; }
        public string TaskTitle { get; set; } = string.Empty;
        public string TaskDescription { get; set; } = string.Empty;
        public string Category {  get; set; }= string.Empty;
        public string Status { get; set; } = string.Empty;
        public DateOnly CreatedAt { get; set; } 
        public DateOnly UpdatedAt { get; set; }



        //======================Relationships(M:1)
        [Required,ForeignKey("UserId")]
        public Users? users { get; set; }
        public int UserId { get; set; }


    }
}
