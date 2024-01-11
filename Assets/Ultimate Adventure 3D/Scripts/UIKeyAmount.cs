using System;
using UnityEngine;
using UnityEngine.UI;

public class UIKeyAmount : MonoBehaviour
{
    [SerializeField] [Tooltip("������, ��������� ����������")] private Inventory inventory;
    [SerializeField] [Tooltip("������� ����������")] private Text text;

    private void Start()
    {
        inventory.ChangeAmountKey.AddListener(OnChangeKeyAmount);
    }

    private void OnDestroy()
    {
        inventory.ChangeAmountKey.RemoveListener(OnChangeKeyAmount);
    }
    private void OnChangeKeyAmount()
    {
        text.text = inventory.GetKeyAmount().ToString();
    }

    
}
