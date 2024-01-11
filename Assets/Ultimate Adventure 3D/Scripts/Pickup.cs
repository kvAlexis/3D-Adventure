using SimpleFPS;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();
        if (fps != null) Destroy(gameObject);
    }
}
