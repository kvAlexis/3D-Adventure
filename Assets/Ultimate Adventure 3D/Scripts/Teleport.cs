using SimpleFPS;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Teleport : MonoBehaviour
{
    [SerializeField] [Tooltip("Выход из телепорта")] private Teleport target;
    [HideInInspector] public bool IsReceive;
    private AudioSource sound;

    private void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (IsReceive == true) return; 
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            target.IsReceive = true;
            fps.transform.position = target.transform.position;
        }

        sound.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            IsReceive = false;
        }
    }
}
