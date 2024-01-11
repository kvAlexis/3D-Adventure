using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] [Tooltip("—сылка на замещающий объект")] private GameObject impactEffect;
    private void OnTriggerEnter(Collider other)
    {
        Inventory inventory = other.GetComponent<Inventory>();
        if (inventory != null)
        {
            inventory.AddKey(1);
            Instantiate(impactEffect);
        }
    }

}
