using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class UIRandomText : MonoBehaviour
{
   private TMP_Text _text;
   [SerializeField] private string[] possibleWords;
   private void Awake()
   {
      _text = GetComponent<TMP_Text>();
   }

   [ContextMenu("Randomize!")]
   public void RandomizeText()
   {
      if (possibleWords.Length == 0)
      {
         return;
      }
      
      
      int randomIndex = Random.Range(0, possibleWords.Length - 1);
      _text.text = possibleWords[randomIndex];
   }
}
