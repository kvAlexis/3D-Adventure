using UnityEngine;

public class Healing : MonoBehaviour
{
    [SerializeField] [Tooltip("Добавляемое количество здоровья")] private int healing;
    [SerializeField] [Tooltip("Ссылка на замещающий объект")] private GameObject impactEffect;

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
