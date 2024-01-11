using SimpleFPS;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class JumpPlatform : MonoBehaviour
{
    [SerializeField] [Tooltip("Увеличение силы прыжка")] private int jumpForce;
    private float defaultJumpForce;
    private AudioSource sound;

    private void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            defaultJumpForce = fps.m_JumpSpeed;
            fps.m_JumpSpeed += jumpForce;
            fps.m_Jump = true;
            sound.Play();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            fps.m_JumpSpeed = defaultJumpForce;
        }
    }
}
