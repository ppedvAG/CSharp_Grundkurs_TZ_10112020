using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modul016_API.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }

    public class TodoItemDTO
    {
        public List<TodoItem> Items { get; set; }
    }
}
