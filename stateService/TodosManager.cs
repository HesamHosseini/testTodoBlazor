using System.Collections;
using System.Xml.Linq;

namespace BlazorTodo.stateService
{
    public class TodosManager
    {
        public class Todo
        {
            string title;
            string discription;
            long id;

            public Todo(string title , string discription , long id )
            {
                this.title = title;
                this.discription = discription;
                this.id = id;
            }

            public String GetTitle() { return title; }
            public string GetDiscription() { return discription; }

            public long GetId() { return id; }
        }


        private List<Todo> Value { get; set; }

        public TodosManager()
        {
            Value = new List<Todo>();
        }


        public event Action OnStateChange;


        public void setValue(List<Todo> value)
        {
            Value = value;
            OnStateChange?.Invoke();
         
        }



        public List<Todo> getValue() { return Value; }
    }
}
