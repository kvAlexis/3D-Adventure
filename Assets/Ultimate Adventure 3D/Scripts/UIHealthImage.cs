using UnityEngine;
using UnityEngine.UI;

public class UIHealthImage : MonoBehaviour
{
    [SerializeField] [Tooltip("������, ���������� ����")] private Destructible destructible;
    [SerializeField] [Tooltip("������� ����������")] private Image image;

    private void Start()
    {
        destructible.ChangeHealthPoints.AddListener(OnChangeHitPoints);
    }

    private void OnDestroy()
    {
        destructible.ChangeHealthPoints.RemoveListener(OnChangeHitPoints);
    }
    private void OnChangeHitPoints()
    {
        image.fillAmount = (float) destructible.GetHitPoints() / (float) destructible.GetMaxHitPoints();
    }
}
