using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Recipe
    {
        private string doctorAssignment;
        private DateTime expirationDate;
        public Recipe(string doctorAssignment, DateTime expirationDate)
        {
            this.doctorAssignment = doctorAssignment;
            this.expirationDate = expirationDate;
        }
        public  string GetDoctorAssigment()
        {
            return doctorAssignment;
        }

        public  DateTime GetExpirationDate()
        {
            return expirationDate;
        }
    }
    public abstract class Decorator : Recipe
    {
        protected Recipe recipe;
        public Decorator(DateTime newdate, Recipe rec):base(rec.GetDoctorAssigment(), newdate)
        {
            recipe = rec;
        }
    }
    public class ExtendRecipe : Decorator
    {
        public ExtendRecipe(DateTime newdate, Recipe recipe) : base(newdate, recipe)
        {
        }
    }
}
