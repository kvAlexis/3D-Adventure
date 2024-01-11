using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTo : MonoBehaviour
{
    [SerializeField] [Tooltip("Скорость перемещения")] private float speed;
    [SerializeField] [Tooltip("Конечная точка")] private Transform target;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}
