using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Helpers;

public class TV : MonoBehaviour, ISwitchable
{
    public bool switchedOn;
    public bool SwitchedOn { get { return switchedOn; } set { switchedOn = value; } }

    public void SwitchOff()
    {
        throw new System.NotImplementedException();
    }

    public void SwitchOn()
    {
        throw new System.NotImplementedException();
    }
}
