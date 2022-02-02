using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimator : MonoBehaviour
{
    private Animator _handAnimator;
    public InputActionReference trigger;
    public InputActionReference grip;

    private void Awake()
    {
        _handAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        _handAnimator.SetFloat("Trigger", trigger.action.ReadValue<float>());
        _handAnimator.SetFloat("Grip", grip.action.ReadValue<float>());
    }

    public void AnimateHandPose(string animationName)
    {
        _handAnimator.Play(animationName);
    }

    public void PlayDefaultHandAnimation()
    {
        _handAnimator.Play("Default");
    }
}
