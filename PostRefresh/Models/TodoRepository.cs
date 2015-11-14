using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostRefresh.Models
{
    public class TodoRepository
    {
        protected List<Todo> Todos { get;}

        public TodoRepository()
        {
            Todos = new List<Todo>();
        }

        public IEnumerable<Todo> GetItems()
        {
            return Todos;
        }

        public void AddItem(string title)
        {
            Todos.Add(new Todo
            {
                Key = Guid.NewGuid().ToString("N"),
                Title = title,
                IsComplete = false
            });
        }
    }
}
