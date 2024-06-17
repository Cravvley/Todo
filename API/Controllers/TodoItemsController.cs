using Application.Todos;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
     public class TodoItemsController:BaseApiController
    {  
        
        [HttpGet]
        public async Task<ActionResult<List<TodoItem>>> GetActivities() => await Mediator.Send(new List.Query());

        [HttpGet("{id}")]
        public async Task<ActionResult<TodoItem>> GetActivity(Guid id)=> await Mediator.Send(new Details.Query{Id=id});
        
    } 
}