using System.Text;

namespace WiredBrainCoffee.ConsoleApp.Model
{
    public class Person
    {
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public override string ToString()
        {
            var builder = new StringBuilder { };
            var b = true;

            foreach (var info in GetType().GetProperties())
            {
                if (b) { b = false; } else { builder.Append("; "); }
                builder.Append($"{info.Name}:{info.GetValue(this)}");
            }

            return builder.ToString();
        }
    }
}