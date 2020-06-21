using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoAPI.Models;

namespace TodoAPI.Controller {
    [Route ("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase {
        public readonly TodoContext _context;
        public TodoController (TodoContext context) {
            _context = context;
            if (_context.TodoItem.Count () == 0) {
                //Create a new TodoItem if collection is empty
                //Which means you can't delete all TodoItems.
                _context.TodoItem.Add (new TodoItem { name = "Item1" });
                _context.SaveChanges ();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoItem>>> GetTodoItems () {
            return await _context.TodoItem.ToListAsync ();
        }

        [HttpGet ("{Id}")]
        public async Task<ActionResult<TodoItem>> GetTodoItem (long Id) {
            var todoItem = await _context.TodoItem.FindAsync (Id);

            if (todoItem == null) {
                return NotFound ();
            }

            return todoItem;
        }

        [HttpPost]
        public async Task<ActionResult<TodoItem>> PostTodoItem (TodoItem item) {
            _context.TodoItem.Add (item);
            await _context.SaveChangesAsync ();

            return CreatedAtAction (nameof (GetTodoItem), new { Id = item.Id }, item);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTodoItem(long id, TodoItem item){
            if(id!= item.Id){
                return BadRequest();
            }

            _context.Entry(item).State= EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTodoItem(long id){
            var todoItem = await _context.TodoItem.FindAsync(id);
            if(todoItem ==null){
                return NotFound();
            }

            _context.TodoItem.Remove(todoItem);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}