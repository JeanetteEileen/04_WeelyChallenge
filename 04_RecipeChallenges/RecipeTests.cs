using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _04_RecipeChallenges
{
    [TestClass]
    public class RecipeTests
    {
        [TestMethod]
        public void RecipeCategoryTests()
        {
            //Are things working in the MainCourse class
            var mainCourse = new MainCourse("pork", "ghee", false, "Pork Chops with Apples ", " pork chops, ghee, rosemary, apples, onion, salt, pepper", " saute and 350 degree oven");
            mainCourse.Title = "Pork Chops with Apples";
            mainCourse.Protein = "Pork";
            mainCourse.Ingredients = "pork chops, ghee, rosemary, apples, onion, salt, pepper";
            mainCourse.Broth = false;
            Console.WriteLine(mainCourse.Title + ", " + mainCourse.Protein + ", There is broth in the recipe: " + mainCourse.Broth);

            //Checking out the sidedish
            var sideDish = new SideDish("Kale and Onion", "kale, onion, Trader Joes Everday Seasoning,", "Saute", "Kale", "No starch", "avocado oil");
            sideDish.Title = "Kale and Onion";
            sideDish.FatSource = "Avocado Oil";
            sideDish.Starch = "";
            Console.WriteLine(sideDish.Title +", "+ sideDish.FatSource +", "+ sideDish.CookingMethod + sideDish.Starch);


            //testing the dessert category
            var dessert = new Dessert(true, "Mug Cake", "cassava flour, coconut sugar, cocoa, baking soda, salt, water,\n" +
                "avocado oil, apple cider vinegar, vanilla", "bake", "");
            dessert.Title = "Mug Cake";
            dessert.Chocolate = true;
            dessert.Fruit = "none";
        
            
            Console.WriteLine(dessert.Title + " " + "This recipe has chocolate" + dessert.Chocolate + " " + "This recipe has fruit" + " " + dessert.Fruit);

            List<Recipe> myRecipes = new List<Recipe>();
            myRecipes.Add(mainCourse);
            mainCourse.PrintRecipe();

            
           
        }
    }
}
