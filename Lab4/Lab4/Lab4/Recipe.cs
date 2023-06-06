using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public abstract class IRecipe
    {
        public abstract string GetDoctorAssigment();
        public abstract string GetStringExpirationDate();
        public abstract DateTime GetExpirationDate();
    }
    public class Recipe : IRecipe
    {
        private string doctorAssignment;
        private DateTime expirationDate;

        public Recipe(string doctorAssignment, DateTime expirationDate)
        {
            this.doctorAssignment = doctorAssignment;
            this.expirationDate = expirationDate;
        }
        
        public override string GetDoctorAssigment()
        {
            return doctorAssignment;
        }

        public override string GetStringExpirationDate()
        {
            return expirationDate.ToShortDateString();
        }
        public override DateTime GetExpirationDate()
        {
            return expirationDate;
        }
    }
    public abstract class RecipeDecorator : IRecipe
    {
        protected IRecipe recipe;

        public  RecipeDecorator(IRecipe recipe)
        {
            this.recipe = recipe;
        }
    }
    public class ExtendRecipe : RecipeDecorator
    {
        private DateTime extendedDate;

        public ExtendRecipe(IRecipe recipe, DateTime extendedDate) : base(recipe)
        {
            this.extendedDate = extendedDate;
        }
        public override string GetDoctorAssigment()
        {
            return recipe.GetDoctorAssigment();
        }
        public override string GetStringExpirationDate()
        {
            return $"{GetExpirationDate().ToShortDateString()} (Extended)";
        }

        public override DateTime GetExpirationDate()
        {
            return extendedDate;
        }
    }
}
