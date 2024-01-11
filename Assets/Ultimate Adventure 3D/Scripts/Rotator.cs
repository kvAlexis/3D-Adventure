using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] [Tooltip("��������� ������")] private Transform targetTransform;
    [SerializeField] [Tooltip("�������� ��������")] private Vector3 speed;

    void Update()
    {
        targetTransform.Rotate(speed * Time.deltaTime);
    }
}
