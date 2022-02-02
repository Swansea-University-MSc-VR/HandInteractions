using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandPhysics : MonoBehaviour
{
    private Collider[] _colliders;

    private IEnumerator Start()
    {
        _colliders = GetComponentsInChildren<Collider>();

        ToggleColliders(false);

        yield return new WaitForSeconds(1f);

        ToggleColliders(true);
    }

    private void ToggleColliders(bool enable)
    {
        foreach (Collider collider in _colliders)
        {
            collider.enabled = enable;
        }
    }
}
