using UnityEngine;

public class Healing : MonoBehaviour
{
    [SerializeField] [Tooltip("����������� ���������� ��������")] private int healing;
    [SerializeField] [Tooltip("������ �� ���������� ������")] private GameObject impactEffect;

    private void OnTriggerEnter(Collider other)
    {
        Destructible destructible = other.GetComponent<Destructible>();

        if (destructible != null)
        {
            destructible.ApplyHealing(healing);
            Instantiate(impactEffect);
        }
    }
}
