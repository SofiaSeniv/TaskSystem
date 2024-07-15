using TaskSystem.Domain.Entity;

namespace TaskSystem.Domain.DTO
{
    public class TaskUpdateDto
    {
        public string Title { get; set; }
        public TaskTag Tag { get; set; }
        public DateTime DueDate { get; set; }
    }
}
