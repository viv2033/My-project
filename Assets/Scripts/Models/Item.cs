using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private string _name = "";
    [SerializeField] private float _weight = 0;
    [SerializeField] private float _price = 0;
    private BoxCollider _boxCollider;

    public void Awake()
    {
        _boxCollider = GetComponent<BoxCollider>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player") { transform.position = new Vector3(0, 1, 0); }
    }
    public void TakeItem()
    {

    }

    public void DropItem()
    {

    }
}
