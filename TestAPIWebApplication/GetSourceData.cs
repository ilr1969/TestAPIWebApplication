namespace TestAPIWebApplication
{
    public static class GetSourceData
    {
        public static List<Person>? SourceData { get; set; }

        public static void SetData()
        {
            SourceData = GetPersonList().Result;

            foreach (var person in SourceData)
            {
                SourceData.First(x => x.Id == person.Id).Age = GetPersonAge(person);
            }
        }

        public static async Task<List<Person>> GetPersonList()
        {
            using HttpClient httpClient = new();
            return await httpClient.GetFromJsonAsync<List<Person>>("http://testlodtask20172.azurewebsites.net/task");
        }

        public static int GetPersonAge(Person person)
        {
            using HttpClient httpClient = new();
            return httpClient.GetFromJsonAsync<Person>($"http://testlodtask20172.azurewebsites.net/task/{person.Id}").Result.Age;
        }

        public static List<Person> GetData()
        {
            return SourceData;
        }
    }
}
