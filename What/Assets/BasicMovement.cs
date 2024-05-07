using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
   
    public Transform PositieHuman;
    public Transform PositieCamera;
    public float Snelheid;

    // Update is called once per frame
    void Update()
    {
        float horizonRichting = Input.GetAxis("Horizontal");
        float verticalRichting = Input.GetAxis("Vertical");

        //Vind de richting die je nu op staat
        Vector3 Looprichting = PositieHuman.rotation.eulerAngles;
        double OrientatieH = (Looprichting.y * (Math.PI))/180;
        double OrientatieV = ((Looprichting.y +90) * (Math.PI)) / 180;
        float XhRichting = (float)(Math.Cos(OrientatieH) * horizonRichting * Snelheid * Time.deltaTime);
        float YhRichting = (float)(Math.Sin(OrientatieH) * horizonRichting * Snelheid * Time.deltaTime);
        float XvRichting = (float)(Math.Cos(OrientatieV) * verticalRichting * Snelheid * Time.deltaTime);
        float YvRichting = (float)(Math.Sin(OrientatieV) * verticalRichting * Snelheid * Time.deltaTime);
        //Vergt nog wat extra aandacht

        //Werkt nog niet goedmet de richting
        Vector3 verplaatsen = new Vector3(XhRichting + XvRichting, 0, YhRichting + YvRichting);
        PositieHuman.position += verplaatsen;
        Vector3 cameraplaats = new Vector3(PositieHuman.position.x,
            PositieHuman.position.y + 2, PositieHuman.position.z);
        PositieCamera.position = cameraplaats;
    }
}
