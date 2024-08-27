using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightswitch : Interactable
{
    [SerializeField] private GameObject lightSource;
    private bool isLightOn = true;

    protected override void Interact()
    {
        isLightOn = !isLightOn;
        lightSource.SetActive(isLightOn);
    }
}
