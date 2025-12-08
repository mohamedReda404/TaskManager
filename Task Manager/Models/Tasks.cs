namespace Task_Manager.Models
{
    public class Tasks
    {
        public int  TaskId { get; set; }
        public string TaskTitle { get; set; } = string.Empty;
        public string TaskDescription { get; set; } = string.Empty;
        public string Category {  get; set; }= string.Empty;
        public string Status { get; set; } = string.Empty;
        public DateOnly CreatedAt { get; set; } 
        public DateOnly UpdatedAt { get; set; }


    }
}
