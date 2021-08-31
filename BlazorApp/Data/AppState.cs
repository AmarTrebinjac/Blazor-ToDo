using System;
using System.Collections.Generic;

namespace BlazorApp.Data
{

    public class AppState
    {
        public List<ToDo> ToDos = new List<ToDo>();
        public void AddToDo(ToDo toDo)
        {
            ToDos.Add(toDo);
            NotifyStateChanged();
        }
        public void RemoveToDo(ToDo toDo)
        {
            ToDos.Remove(toDo);
            NotifyStateChanged();
        }
        public event Action OnChange;
        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
