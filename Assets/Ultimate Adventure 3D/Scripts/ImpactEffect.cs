using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactEffect : MonoBehaviour
{
    [SerializeField] [Tooltip("����� ����� �������")] private float lifeTime;
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }
}
