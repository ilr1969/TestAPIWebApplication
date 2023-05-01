namespace TestAPIWebApplication
{
    public class PersonAllView
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Sex { get; set; }

        public PersonAllView(string id, string name, string sex)
        {
            Id = id;
            Name = name;
            Sex = sex;
        }
    }
}
