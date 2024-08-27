using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractController : MonoBehaviour
{
    [SerializeField] private float distance = 5f;
    [SerializeField] private LayerMask mask;

    private Camera cam;
    private PlayerUI playerUI;
    private InputManager inputManager;

    private void Start()
    {
        cam = GetComponent<CameraController>().cam;
        playerUI = GetComponent<PlayerUI>();
        inputManager = GetComponent<InputManager>();
    }

    private void Update()
    {
        playerUI.UpdateText(string.Empty); 
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * distance);
        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo, distance, mask)) 
        { 
            if (hitInfo.collider.GetComponent<Interactable>() != null)
            {
                var interactable = hitInfo.collider.GetComponent<Interactable>();
                playerUI.UpdateText(interactable.message);
                if (inputManager.onMovement.Interact.triggered)
                {
                    interactable.BaseInteract();
                }
            }
        }
    }
}
