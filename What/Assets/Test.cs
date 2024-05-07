using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour, IToInteract
{
    public Transform Positie;

    public void Interact()
    {
        Vector3 vliegweg = new Vector3(Positie.position.x, Positie.position.y + 100, Positie.position.z);
        Positie.position = vliegweg;
    }
}
