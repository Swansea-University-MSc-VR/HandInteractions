using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimatorDemo : MonoBehaviour
{
    public Animator animator;

    public InputActionReference trigger;
    public InputActionReference grip;


    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Trigger", trigger.action.ReadValue<float>());
        animator.SetFloat("Grip", grip.action.ReadValue<float>());
    }

    public void AnimateHandPose(string animationName)
    {
        animator.Play(animationName);
    }

    public void PlayDefaultHandAnimation()
    {
        animator.Play("Default");
    }
}
