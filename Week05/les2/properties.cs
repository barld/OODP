using System;

namespace PropertyExamples
{
    public class Person
    {
        // 1. Auto-Implemented Properties
        public string Name { get; set; }

        // 2. Auto-Implemented Properties with Initializers
        public string Nickname { get; set; } = "Unknown";

        // 3. Read-Only Auto-Implemented Properties
        public string ReadOnlyName { get; }

        public Person(string name)
        {
            ReadOnlyName = name;
        }

        // 4. Expression-Bodied Properties
        private string _fullName;
        public string FullName
        {
            get => _fullName;
            set => _fullName = value;
        }

        // 5. Properties with Backing Fields
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        // 6. Init-Only Properties
        public string InitOnlyName { get; init; }

        // 7. Required Properties (C# 11 feature)
        public required string RequiredName { get; set; }

        // 8. Properties with Custom Attributes
        [Obsolete("Use NewProperty instead.")]
        public string OldProperty { get; set; }

        public string NewProperty { get; set; }

        // 9. Properties with Private Setters
        public string NameWithPrivateSetter { get; private set; }

        public Person(string name, string privateSetterName)
        {
            NameWithPrivateSetter = privateSetterName;
        }

        // 10. Properties with Lazy Initialization
        private Lazy<string> _lazyName = new Lazy<string>(() => "Default Name");
        public string LazyName => _lazyName.Value;

        // 11. Properties with Custom Access Modifiers
        public string NameWithInternalSetter { get; internal set; }

        // 12. Properties with Indexers
        private string[] _data = new string[10];
        public string this[int index]
        {
            get => _data[index];
            set => _data[index] = value;
        }

        // 13. Properties with Events
        private string nameWithEvent;
        public string NameWithEvent
        {
            get => nameWithEvent;
            set
            {
                if (nameWithEvent != value)
                {
                    nameWithEvent = value;
                    OnNameChanged();
                }
            }
        }

        public event Action NameChanged;
        protected virtual void OnNameChanged()
        {
            NameChanged?.Invoke();
        }
    }

    public class Rectangle
    {
        // 14. Computed Properties
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area => Width * Height;
    }

    public class Temperature
    {
        // 15. Properties with Logic in Getter/Setter
        private double celsius;
        public double Fahrenheit
        {
            get => celsius * 9 / 5 + 32;
            set => celsius = (value - 32) * 5 / 9;
        }
    }

    public class TimePeriod
    {
        // 16. Properties with the 'field' Keyword (C# 13)
        public double Hours
        {
            get => field;
            set => field = (value >= 0) ? value : throw new ArgumentOutOfRangeException(nameof(value), "The value must not be negative");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Example usage of the classes
            var person = new Person("John", "John Private")
            {
                Name = "John Doe",
                Nickname = "Johnny",
                Age = 30,
                InitOnlyName = "John Init",
                RequiredName = "John Required",
                NewProperty = "New Value",
                NameWithInternalSetter = "Internal Setter"
            };

            var rectangle = new Rectangle
            {
                Width = 5,
                Height = 10
            };

            var temperature = new Temperature
            {
                Fahrenheit = 98.6
            };

            var timePeriod = new TimePeriod
            {
                Hours = 24
            };

            Console.WriteLine($"Person: {person.Name}, {person.Nickname}, {person.ReadOnlyName}, {person.Age}, {person.InitOnlyName}, {person.RequiredName}, {person.NewProperty}, {person.NameWithPrivateSetter}, {person.LazyName}, {person.NameWithInternalSetter}");
            Console.WriteLine($"Rectangle Area: {rectangle.Area}");
            Console.WriteLine($"Temperature in Celsius: {temperature.Fahrenheit}");
            Console.WriteLine($"Time Period in Hours: {timePeriod.Hours}");
        }
    }
}