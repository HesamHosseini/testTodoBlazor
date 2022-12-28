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
            string bgColor;

            public Todo(string title , string discription , long id , string bgColor )
            {
                this.title = title;
                this.discription = discription;
                this.id = id;
                this.bgColor = bgColor;
            }


            // getters 

            public String GetTitle() { return title; }
            public string GetDiscription() { return discription; }

            public long GetId() { return id; }

            public string GetBgColor () { return bgColor; }



            // setters 

            public void setTitle(string newTitle)
            {
                title = newTitle;
            }

            public void setDiscription(string newDiscription)
            {
                discription = newDiscription;
            }
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
