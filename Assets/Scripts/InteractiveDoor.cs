using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class InteractiveDoor : MonoBehaviour, IInteractive
{
    [SerializeField]
    private string displayText = nameof(InteractiveObject);
    public string DisplayText => displayText;
    private AudioSource audioSource;
    public Animator DoorAnim;
    private void Awake()
    {
        DoorAnim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }
    public void InteractWith()
    {
        try
        {
            int x = 0;
            audioSource.Play();
            DoorAnim.SetTrigger("open sesame");
        }

        catch (System.Exception)
        {

            throw new System.Exception("Interactive Object requires an Auidio Source Component.");
        }

        Debug.Log($"Player just interacted with {gameObject.name}.");
    }
}
