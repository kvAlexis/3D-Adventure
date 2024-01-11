using UnityEngine;
using UnityEngine.Events;

public class Destructible : MonoBehaviour
{
    [SerializeField] [Tooltip("Максимальный уровень здоровья")] private int MaxHealthPoints;
    private int healthPoints;
    public UnityEvent Death;
    public UnityEvent ChangeHealthPoints;

    private void Start()
    {
        healthPoints = MaxHealthPoints;
        ChangeHealthPoints.Invoke();
    }

    public int GetHitPoints()
    {
        return healthPoints;
    }

    public int GetMaxHitPoints()
    {
        return MaxHealthPoints;
    }
    public void ApplyDamage(int damage)
    {
        healthPoints -= damage;
        ChangeHealthPoints.Invoke();

        if (healthPoints <= 0)
        {
            Kill();
        }
    }

    public void ApplyHealing(int healing)
    {
        healthPoints += healing;
        ChangeHealthPoints.Invoke();
         if (healthPoints >= MaxHealthPoints) healthPoints = MaxHealthPoints;
    }

    public void Kill()
    {
        healthPoints = 0;
        Death.Invoke();
        ChangeHealthPoints.Invoke();
    }
}
