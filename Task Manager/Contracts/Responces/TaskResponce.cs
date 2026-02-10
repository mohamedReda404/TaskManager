namespace Task_Manager.Contracts.Responces
{
    public record TaskResponce
   (
        int Id,
        string TaskTitle,
        string TaskDescription,
        string Category,
        string Status,
        DateOnly CreatedAt,
        DateOnly UpdatedAt,
        int UserId
        );
}
