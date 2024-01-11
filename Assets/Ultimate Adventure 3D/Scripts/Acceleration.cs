using SimpleFPS;
using UnityEngine;

public class Acceleration : MonoBehaviour
{
    [SerializeField] [Tooltip("Увеличение скорости")] private int bonus;
    private void OnTriggerEnter(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            fps.m_JumpSpeed += bonus;
            fps.m_RunSpeed += bonus;
            fps.m_WalkSpeed += bonus;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            fps.m_JumpSpeed -= bonus;
            fps.m_RunSpeed -= bonus;
            fps.m_WalkSpeed -= bonus;
        }
    }
}
