using System;
using System.Collections.Generic;

namespace Recipes
{
    [Serializable]
    public class Recipe
    {
        public List<Ingredient> Ingredients;
        public List<RecipeStep> Steps;
    }
}