using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_RecipeChallenges
{
    public abstract class Recipe
    {
        public string Title { get; set; }
        public string CookingMethod { get; set; }
        public string Ingredients { get; set; }
        
        public virtual void PrintRecipe()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Cooking Method: " + CookingMethod);
            Console.WriteLine("Ingredients: " + Ingredients);
        }

        public Recipe() { }

        public Recipe(string title, string ingredients, string cookingMethod)
        {
            Title = title;
            Ingredients = ingredients;
            CookingMethod = cookingMethod;

        }
    }
    public class MainCourse : Recipe
    {
        public string Protein { get; set; }
        public string FatSource { get; set; }
        public bool Broth { get; set; }
        public MainCourse() { }

        public MainCourse(string protein, string fatSource, bool broth, string title, string ingredients, string cookingMethod)
            : base(title, ingredients, cookingMethod)
        {
            Protein = protein;
            FatSource = fatSource;
            Broth = broth;
        }
        public override void PrintRecipe()
        {
            Console.WriteLine($"I only want the title and Cooking Method: " + Title + " Cooking method:"  + CookingMethod);
        }
    }
    public class SideDish : Recipe
    {
        public string Vegetable { get; set; }
        public string Starch { get; set; }
        public string FatSource { get; set; }
        public SideDish(string title, string ingredients, string cookingMethod, string vegetable, string starch, string fatSource)
            : base(title, ingredients, cookingMethod)
        {
            Vegetable = vegetable;
            Starch = starch;
            FatSource = fatSource;
            Console.WriteLine("Print the recipe: " + Title + " Ingredients: " + Ingredients + " Cooking Method: " + CookingMethod + " ");
        }
    }
    public class Dessert : Recipe
    {
        public bool Chocolate { get; set; }
        public string Fruit { get; set; }

        public Dessert(bool chocolate, string title, string ingredients, string cookingMethod, string fruit)
            : base(title, ingredients, cookingMethod)
        {
            Chocolate = chocolate;
            Fruit = fruit;
        }
    }
}
