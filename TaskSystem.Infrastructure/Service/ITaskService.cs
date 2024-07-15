using TaskSystem.Domain.DTO;
using TaskSystem.Domain.Entity;

namespace TaskSystem.Infrastructure.Service
{
    public interface ITaskService
    {
        List<TaskEntity> GetAll();
        TaskEntity GetById(int id);
        void Create(TaskEntity entity);
        void Update(int id, TaskUpdateDto updateDto);
        void Delete(int id);
        List<TaskEntity> FilterTasksByTag(TaskTag tag);
    }
}
