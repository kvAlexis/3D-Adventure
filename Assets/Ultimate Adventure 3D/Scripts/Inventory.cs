using UnityEngine;
using UnityEngine.Events;

public class Inventory : MonoBehaviour
{
    private int keyAmount;
    public UnityEvent ChangeAmountKey;

    public void AddKey(int amount)
    {
        keyAmount += amount;
        ChangeAmountKey.Invoke();
    }

    public bool DrawKey(int amount)
    {
        if (keyAmount - amount < 0) return false;
        keyAmount -= amount;
        ChangeAmountKey.Invoke();
        return true;
    }

    public int GetKeyAmount()
    {
        return keyAmount;
    }
}
