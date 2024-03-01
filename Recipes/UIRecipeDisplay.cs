using TMPro;
using UnityEngine;

namespace Recipes
{
    public class UIRecipeDisplay : MonoBehaviour
    {
        public Recipe recipe;

        private int stepIndex;//the current step
        public TMP_Text InstructionText;

        void Start()
        {
            RefreshUI();
        }
        
        public void RefreshUI()
        {
            InstructionText.text = (stepIndex + 1)+": "+recipe.Steps[stepIndex].Instructions;
        }

        public void GoToPrevStep()
        {
            stepIndex--;
            //loop around
            if (stepIndex < 0)
            {
                stepIndex =  recipe.Steps.Count -1;
            }
            RefreshUI();
        }
        public void GoToNextStep()
        {
            stepIndex++;
            //loop around
            if (stepIndex >= recipe.Steps.Count)
            {
                stepIndex = 0;
            }
            RefreshUI();
        }
    }
}