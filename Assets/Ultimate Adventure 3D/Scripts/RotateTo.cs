using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTo : MonoBehaviour
{
    [SerializeField] [Tooltip("—корость поворота")] private float speed;
    [SerializeField] [Tooltip("”гол поворота")] private Vector3 target;

    void Update()
    {
        transform.localRotation = Quaternion.RotateTowards(transform.localRotation, Quaternion.Euler(target), speed * Time.deltaTime);
    }
}
