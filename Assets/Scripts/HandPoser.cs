using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HandPoser : MonoBehaviour
{
    public XRInteractorReferences xrInteractorReferences;

    private XRDirectInteractor _currentDirectInteractor;

    private XRGrabInteractable _grabInteractable;
    public string poseAnimationName;

    private void Start()
    {
        xrInteractorReferences = FindObjectOfType<XRInteractorReferences>();
        _grabInteractable = GetComponent<XRGrabInteractable>();

        _grabInteractable.selectEntered.AddListener(CheckHandToPose);
        _grabInteractable.selectExited.AddListener(StopHandPosing);
    }

    public void CheckHandToPose(SelectEnterEventArgs args)
    {
        if (_grabInteractable.interactorsSelecting[0] == xrInteractorReferences.leftHandDirectInteractor)
        {
            _currentDirectInteractor = xrInteractorReferences.leftHandDirectInteractor;
            xrInteractorReferences.leftHandAnimator.AnimateHandPose(poseAnimationName);

        }
        else
        {
            _currentDirectInteractor = xrInteractorReferences.rightHandDirectInteractor;
            xrInteractorReferences.rightHandAnimator.AnimateHandPose(poseAnimationName);
        }
    }

    public void StopHandPosing(SelectExitEventArgs args)
    {
        if (_currentDirectInteractor == xrInteractorReferences.leftHandDirectInteractor)
        {
            xrInteractorReferences.leftHandAnimator.PlayDefaultHandAnimation();
        }
        else
        {
            xrInteractorReferences.rightHandAnimator.PlayDefaultHandAnimation();
        }
    }

    private void OnDestroy()
    {
        _grabInteractable.selectEntered.RemoveAllListeners();
        _grabInteractable.selectExited.RemoveAllListeners();
    }

}
