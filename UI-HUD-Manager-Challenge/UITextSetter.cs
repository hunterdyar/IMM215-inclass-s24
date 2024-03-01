using UnityEngine;

public class UITextSetter : MonoBehaviour {

   private UIHUDManager HUDManager;

   void Awake(){
      HUDManager = GetComponent<UIHUDManager>();
   }
    
void Update(){

   HUDManager.SetHealth(Random.value);
   HUDManager.SetFlightTime(Random.value);
   HUDManager.SetBoost(Random.value);
}
    

}
