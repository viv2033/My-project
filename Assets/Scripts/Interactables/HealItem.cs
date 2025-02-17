using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealItem : Interactable
{
    protected override void Interact()
    {
        GameObject player = GameObject.FindWithTag("Player");
        PlayerController controller = player.GetComponent<PlayerController>();
        controller.UpdateHp(25);
        Destroy(gameObject);
    }
 
}
