using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LightSwitch : MonoBehaviour
{
    XRSimpleInteractable xRSimpleInteractable;

    public Light[] lights;
    public MeshRenderer[] lightMeshRenderers;
    public Material lightOffMat;
    public Material lightOnMat;

    private void Start()
    {
        xRSimpleInteractable = GetComponent<XRSimpleInteractable>();

        xRSimpleInteractable.hoverEntered.AddListener(ToggleLights);
    }

    private void ToggleLights(HoverEnterEventArgs args)
    {
        if (lights[0].enabled)        
            TurnLightsOff();        
        else
            TurnLightsOn();
    }

    private void TurnLightsOff()
    {
        for (int i = 0; i < lights.Length; i++)
        {
            lights[i].enabled = false;
        }

        for (int i = 0; i < lightMeshRenderers.Length; i++)
        {
            lightMeshRenderers[i].material = lightOffMat;
        }
    }

    private void TurnLightsOn()
    {
        for (int i = 0; i < lights.Length; i++)
        {
            lights[i].enabled = true;
        }

        for (int i = 0; i < lightMeshRenderers.Length; i++)
        {
            lightMeshRenderers[i].material = lightOnMat;
        }
    }

    private void OnDestroy()
    {
        xRSimpleInteractable.hoverEntered.RemoveAllListeners();
    }
}
