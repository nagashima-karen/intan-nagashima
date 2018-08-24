using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scream : MonoBehaviour {
    
    [SerializeField]
    private AudioSource audioSource = null;
    [SerializeField]
    private Animator animator;

    void update()
    {
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
        if (stateInfo.nameHash == Animator.StringToHash("Base Layer.Idle01"))
        {
            audioSource.Play();
        }    
    }
}
