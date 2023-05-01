﻿namespace TestAPIWebApplication
{
    public class Person
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Sex { get; set; }

        public int Age { get; set; }

        public Person(string id, string name, string sex, int age)
        {
            Id = id;
            Name = name;
            Sex = sex;
            Age = age;
        }
    }
}
