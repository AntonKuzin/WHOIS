namespace Library
{
    public class RequestContainer
    {
        public string query;

        public int fields;

        public RequestContainer(string query, int fields = 8209)
        {
            this.query = query;
            this.fields = fields;
        }
    }
}
