using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI proText;

    public void UpdateText(string message)
    {
        proText.text = message;
    } 
}
