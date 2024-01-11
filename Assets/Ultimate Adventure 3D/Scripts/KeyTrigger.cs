using UnityEngine;
using UnityEngine.Events;

public class KeyTrigger : MonoBehaviour
{
    [SerializeField] [Tooltip("Сообщение, элемент интерфейса")] private GameObject messageBox;
    [SerializeField] [Tooltip("Количество ключей для активации ворот")] private int keyActivateAmount;
    [SerializeField] private UnityEvent Enter;
    private bool isActive = false;

    protected void OnTriggerEnter(Collider other)
    {
        if (isActive == true) return;

        Inventory inventory = other.GetComponent<Inventory>();

        if (inventory != null)
        {
            if (inventory.DrawKey(keyActivateAmount) == true)
            {
                Enter.Invoke();
                isActive = true;
            }
            else
            {
                messageBox.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        messageBox.SetActive(false);
    }

}
