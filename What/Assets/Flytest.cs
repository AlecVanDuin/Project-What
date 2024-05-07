using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flytest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Transform Ah;
    // Update is called once per frame
    void Update()
    {
        Vector3 vlieg = new Vector3(0, 100, 0);
        Ah.position += vlieg;
    }
}
