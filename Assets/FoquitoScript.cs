using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoquitoScript : MonoBehaviour
{
    [SerializeField] GameObject[] colors;
    public int currentLightIndex =-1;

    public void ActivateNextLight()
    {
        currentLightIndex++;
        if (currentLightIndex >= colors.Length)
        {
            currentLightIndex = 0;
        }
        DeactivateAllLights();
        colors[currentLightIndex].SetActive(true);
    }

    public void ActivatePreviousLight()
    {
        currentLightIndex--;
        if (currentLightIndex < 0)
        {
            currentLightIndex = colors.Length - 1;
        }
        DeactivateAllLights();
        colors[currentLightIndex].SetActive(true);
    }

    void DeactivateAllLights()
    {
        for (int i = 0; i < colors.Length; i++) 
        {
            colors[i].SetActive(false); 
        }
    }

    public void ActivateRepeating(float t)
    {
        CancelInvoke();
        InvokeRepeating(nameof(ActivateNextLight),0,t);
    }
}
