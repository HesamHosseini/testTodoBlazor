using System.Security.Cryptography.X509Certificates;

namespace BlazorTodo.stateService
{
    public class InputStateManagment
    {

        private Dictionary<string, string> Value { get; set; }

        public event Action OnStateChange;

        public InputStateManagment()
        {
            Value = new Dictionary<string, string>
            {
                { "title", "" },
                { "discription", "" }
         
            };
        }


        public Dictionary<string, string> GetValue() { return Value; }

        public void setValue(Dictionary<string, string> value)
        {

            Value = value;

            OnStateChange?.Invoke();
        }

    }
}
