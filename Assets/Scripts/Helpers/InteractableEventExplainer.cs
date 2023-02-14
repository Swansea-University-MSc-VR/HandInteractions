using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableEventExplainer : MonoBehaviour
{
    public void OnHover()
    {
        Debug.Log("OnHover");
    }

    public void OnSelect()
    {
        Debug.Log("OnSelect");
    }

    public void OnActivate()
    {
        Debug.Log("OnActivate");
    }
}
