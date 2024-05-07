using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class ObjectInteraction : MonoBehaviour
{
    public Transform ObjectLocation;
    public Transform PlayerLocation;
    public float ObjectRange;
    public GameObject Objectje;

    // public Component Vervolg;

    // Update is called once per frame
    void Update()
    {
        if (Math.Sqrt(Math.Pow(ObjectLocation.position.x - PlayerLocation.position.x, 2) +
            Math.Pow(ObjectLocation.position.z - PlayerLocation.position.z, 2)) < ObjectRange)
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                if (Objectje.TryGetComponent(out IToInteract clickableObject))
                {
                    clickableObject.Interact();
                }
            }
        }
    }
}
