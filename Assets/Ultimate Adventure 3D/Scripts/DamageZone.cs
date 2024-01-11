using UnityEngine;

public class DamageZone : MonoBehaviour
{
    [SerializeField] [Tooltip("��������� ����")] private int damage;
    [SerializeField] [Tooltip("������������� ��������� �����")] private float damageRate;
    [SerializeField] [Tooltip("���� ��������� �����")] private AudioSource damageSound;
    private Destructible destructible;
    private float timer;
    
    private void Update()
    {
        if (destructible == null) return;
        timer += Time.deltaTime;

        if (timer >= damageRate)
        {
            if (destructible != null)
            {
                destructible.ApplyDamage(damage);
            }

            timer = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        destructible = other.GetComponent<Destructible>();
        damageSound.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Destructible>() == destructible) destructible = null;
        damageSound.Stop();
    }
}
