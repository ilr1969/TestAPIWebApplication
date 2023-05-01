namespace TestAPIWebApplication
{
    public class ApiFilterArgs
    {
        private int _Page = 1;
        public int Page
        {
            get { return _Page; }
            set { _Page = value; }
        }
        private int _PageSize = 3;
        public int PageSize
        {
            get { return _PageSize; }
            set { _PageSize = value; }
        }
        private List<string> _Sex = new List<string> { "male", "female" };
        public List<string> Sex
        {
            get { return _Sex; }
            set { _Sex = value; }
        }
        public string _Ages = "0-100";
        public string Ages
        {
            get { return _Ages; }
            set { _Ages = value; }
        }
    }
}
