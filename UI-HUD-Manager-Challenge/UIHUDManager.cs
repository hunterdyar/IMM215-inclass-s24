using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIHUDManager : MonoBehaviour
{
    public TMP_Text healthText;
    public TMP_Text flightText;
    public TMP_Text boostText;

    public void SetHealth(float newHealth)
    {
        healthText.text = "Health: "+newHealth.ToString("N0");	
    }

    public void SetFlightTime(float newFlightTime)
    {
	flightText.text = "Flight Time: "+newFlightTime.ToString();
    }
    public void SetBoost(float boost)
    {
       boostText.text = "Boost: "+boost.ToString();
    }
}
