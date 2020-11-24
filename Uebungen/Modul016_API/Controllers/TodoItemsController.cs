using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Modul016_API.Data;
using Modul016_API.Models;

namespace Modul016_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemsController : ControllerBase
    {
        private readonly TodoContext _context;

        public TodoItemsController(TodoContext context)
        {
            // beim Erstellen des TodoItemsController wird der TodoContext (EntityFrameworkCore) initilisiert
            // der Context verwaltet die Datenzugriffe auf die Datenbank
            _context = context;
        }

        // GET: api/TodoItems
        // alle in der DB gespeicherten TodoItems 
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoItem>>> GetTodoItem()
        {
            return await _context.TodoItems.ToListAsync();
        }

        // GET: api/TodoItems/5
        // das TodoItem mit der {id} als Primaerschluessel wird zurueckgegeben
        [HttpGet("{id}")]
        public async Task<ActionResult<TodoItem>> GetTodoItem(long id)
        {
            var todoItem = await _context.TodoItems.FindAsync(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;
        }

        // GET: api/TodoItems/2-5
        // alle TodoItems mit einem Primaerschluessel zwischen {id} und {id2} werden zurueckgegeben
        [HttpGet("{id}-{id2}")]
        public async Task<ActionResult<IEnumerable<TodoItem>>> GetTodoItemsRange(long id, long id2)
        {
            return await _context.TodoItems.Where(tdi => tdi.Id >= id && tdi.Id <= id2).ToListAsync();
        }

        // PUT: api/TodoItems/5
        // das TodoItem mit der {id} wird mit dem Body der PUT-Anweisung ueberschrieben
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTodoItem(long id, TodoItem todoItem)
        {
            if (id != todoItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(todoItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TodoItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TodoItems
        // ein neues TodoItem wird mit dem Body der POST-Anweisung erstellt
        [HttpPost]
        public async Task<ActionResult<TodoItem>> PostTodoItem(TodoItem todoItem)
        {
            _context.TodoItems.Add(todoItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
        }

        // POST: api/TodoItems/BulkPost
        // durch ein DTO (Data Transfer Object) koennen mehrere TodoItems über eine POST-Anweisung erstellt werden
        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult<TodoItem>> BulkPost(TodoItemDTO todoItemDTO)
        {
            foreach (var item in todoItemDTO.Items)
            {
                _context.TodoItems.Add(item);
            }

            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/TodoItems/5
        // das TodoItem mit der {id} wird mit einer DELETE-Anweisung geloescht
        [HttpDelete("{id}")]
        public async Task<ActionResult<TodoItem>> DeleteTodoItem(long id)
        {
            var todoItem = await _context.TodoItems.FindAsync(id);
            if (todoItem == null)
            {
                return NotFound();
            }

            _context.TodoItems.Remove(todoItem);
            await _context.SaveChangesAsync();

            return todoItem;
        }

        private bool TodoItemExists(long id)
        {
            return _context.TodoItems.Any(e => e.Id == id);
        }
    }
}
