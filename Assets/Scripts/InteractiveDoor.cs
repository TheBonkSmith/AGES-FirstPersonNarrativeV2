using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class InteractiveDoor : InteractiveObject
{
    [SerializeField]
    private bool isLocked;

    [Tooltip("text that displays when door is locked")]
    [SerializeField]
    private string lockedDisplayText = "Locked";

    [SerializeField]
    private AudioClip lockedAudioClip;


    [SerializeField]
    private AudioClip openAudioClip;

    public override string DisplayText => isLocked ? lockedDisplayText : base.DisplayText;

    private bool isOpen = false;
    private Animator animator;

    public InteractiveDoor()
    {
        displayText = nameof(InteractiveDoor);
    }

    protected override void Awake()
    {
        base.Awake();
        animator = GetComponent<Animator>();
    }

    public override void InteractWith()
    {
        if (!isOpen)
        {
            if (!isLocked)
            {
                audioSource.clip = openAudioClip;
                animator.SetTrigger("open sesame");
                displayText = string.Empty;
            }
            else //if lcoked
            {
                audioSource.clip = lockedAudioClip;
            }
            base.InteractWith();
        }

    }
}
