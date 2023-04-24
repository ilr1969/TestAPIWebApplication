using System.ComponentModel;

namespace TestAPIWebApplication
{
    public static class GetSourceData
    {
        public static List<Person> SourceData { get; set; }

        public static async Task SetData()
        {
            using HttpClient httpClient = new HttpClient();
            var qSourceData = await httpClient.GetAsync("http://testlodtask20172.azurewebsites.net/task");
            var wSourceData = qSourceData.Content.ReadFromJsonAsync<Person>();
            var t = "";
        }

        public static List<Person> GetData()
        {
            return SourceData;
        }
    }
}
