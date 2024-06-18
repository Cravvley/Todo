using Application.Todos;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
     public class TodoItemsController:BaseApiController
    {  
        
        [HttpGet]
        public async Task<ActionResult<List<TodoItem>>> GetTodos() => await Mediator.Send(new List.Query());

        [HttpGet("{id}")]
        public async Task<ActionResult<TodoItem>> GetTodo(Guid id)=> await Mediator.Send(new Details.Query{Id=id});
        
        [HttpPost]
        public async Task<IActionResult> CreateTodo (TodoItem todoItem) {
          await Mediator.Send(new Create.Command{TodoItem = todoItem}); 
           
          return Ok();
        } 

        [HttpPut("{id}")]
        public async Task<IActionResult> EditTodo (Guid id, TodoItem todoItem) {
          todoItem.Id = id; 
          await Mediator.Send(new Edit.Command{TodoItem = todoItem});  
          return Ok();
        } 

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodo (Guid id) {
          await Mediator.Send(new Delete.Command{Id = id});  
          return Ok();
        } 
    } 
}