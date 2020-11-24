using System;
using System.Collections.Generic;
using System.Text;

namespace Modul016_API_Console
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }

    public class TodoItemDTO
    {
        public List<TodoItem> items; 
    }
}
