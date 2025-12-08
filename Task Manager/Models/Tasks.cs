

namespace Task_Manager.Models
{
    public class Tasks
    {
        [Key]
        public int  TaskId { get; set; }
        [Required, MaxLength(100)]
        public string TaskTitle { get; set; } = string.Empty;
        [Required, MaxLength(500)]
        public string TaskDescription { get; set; } = string.Empty;
        [Required]
        public string Category {  get; set; }= string.Empty;
        [Required]
        public string Status { get; set; } = string.Empty;
        [Required]
        public DateOnly CreatedAt { get; set; } 
        [Required]
        public DateOnly UpdatedAt { get; set; }



        //======================Relationships(M:1)
        [Required,ForeignKey("UserId")]
        public Users? users { get; set; }
        public int UserId { get; set; }


    }
}
