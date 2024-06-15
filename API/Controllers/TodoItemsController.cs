using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
     public class TodoItemsController:BaseApiController
    {
        private readonly DataContext _context;
        public TodoItemsController(DataContext context)
        {
            _context = context;
        }        
        
        [HttpGet]
        public async Task<ActionResult<List<TodoItem>>> GetActivities() => await _context.TodoItems.ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<TodoItem>> GetActivity(Guid id)=> await _context.TodoItems.FindAsync(id);
        
    } 
}