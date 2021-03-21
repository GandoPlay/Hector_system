namespace Hatal_idf
{
    public class ActionMessage
    {
        private string action = "";
        private readonly bool isOk = false;

        public ActionMessage()
        {

        }

        public string Action { get; set; }

        public bool IsOk { get; set; }
    }
}