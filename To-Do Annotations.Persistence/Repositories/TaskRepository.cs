using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using To_Do_Annonations.Domain.Entities;
using To_Do_Annotations.Application.Contracts;
using To_Do_Annotations.Persistence.Database;
using AppContext = To_Do_Annotations.Persistence.Database.AppContext;

namespace To_Do_Annotations.Persistence.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly AppContext _context;
        private readonly ILogger<TaskRepository> _logger; 

        public TaskRepository(AppContext context, ILogger<TaskRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public Task AddAsync(ToDoTask task)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ToDoTask>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ToDoTask?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ToDoTask task)
        {
            throw new NotImplementedException();
        }
    }
}
