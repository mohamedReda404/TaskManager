namespace Task_Manager.Contracts.Requestes
{
    public record TaskRequest
    (
       
        string TaskTitle,
        string TaskDescription,
        string Category,
        string Status,
        DateOnly CreatedAt,
        DateOnly UpdatedAt,
        int UserId
        );
}
