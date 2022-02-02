using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetFixedDeltaTime : MonoBehaviour
{
    public static SetFixedDeltaTime Instance { get; private set; }

    public float refreshRate;

    private void Awake()
    {

        if (!Instance)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this);
            return;
        }
    }

    private void Start()
    {
        refreshRate = UnityEngine.XR.XRDevice.refreshRate;

        if (refreshRate < 60f)
        {
            refreshRate = 90f;
        }

        Time.fixedDeltaTime = 1f / refreshRate;

        if (Debug.isDebugBuild)
            LogCurrentDeltaTimeInfo();
    }

    public void LogCurrentDeltaTimeInfo()
    {
        UnityEngine.Debug.LogFormat("Device Resfresh Rate is {0}. Setting fixedDeltaTime to {1}", refreshRate, Time.fixedDeltaTime);
    }
}
