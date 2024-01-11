using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] [Tooltip("Вращаемый объект")] private Transform targetTransform;
    [SerializeField] [Tooltip("Скорость вращения")] private Vector3 speed;

    void Update()
    {
        targetTransform.Rotate(speed * Time.deltaTime);
    }
}
