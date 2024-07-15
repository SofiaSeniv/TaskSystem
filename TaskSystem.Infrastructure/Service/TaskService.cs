using AutoMapper;
using TaskSystem.Domain.DTO;
using TaskSystem.Domain.Entity;

namespace TaskSystem.Infrastructure.Service
{
    public class TaskService : ITaskService
    {
        private TaskSystemDbContext _context;
        private IMapper _mapper;
        private const string NOT_FOUND = "Task was not found";

        public TaskService(TaskSystemDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Create(TaskEntity entity) //TODO: dto for create 
        {
            _context.Tasks.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _context.Tasks.Find(id) ?? throw new Exception(NOT_FOUND);

            _context.Tasks.Remove(entity);
            _context.SaveChanges();
        }

        public List<TaskEntity> FilterTasksByTag(TaskTag tag)
        {
            return _context.Tasks.Where(t => t.Tag == tag).ToList();
        }

        public List<TaskEntity> GetAll()
        {
            return _context.Tasks.ToList();
        }

        public TaskEntity GetById(int id)
        {
            return _context.Tasks.Find(id) ?? throw new Exception(NOT_FOUND);
        }

        public void Update(int id, TaskUpdateDto updateDto)
        {
            var updateEntity = _context.Tasks.Find(id) ?? throw new Exception(NOT_FOUND);

            _mapper.Map(updateDto, updateEntity);

            _context.Tasks.Update(updateEntity);
            _context.SaveChanges();
        }
    }
}
