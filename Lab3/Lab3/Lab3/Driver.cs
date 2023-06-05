using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Driver
    {
        public enum Category
        {
            Category_A,
            Category_B
        }
        public Category category { get; set; }
        public Driver(string category)
        {
            this.category = (Category)Enum.Parse(typeof(Category), category);
        }
    }
}
