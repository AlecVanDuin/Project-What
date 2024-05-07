using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rondkijken : MonoBehaviour
{
    //We gebruiken de rotatie van de Camera en van de Human.
    //De draaisnelheid bepaald hoe snel hij horizontaal draait.
    public Transform Camera;
    public Transform Human;
    public float draaisnelheid;
    public float GeenRotatieY;
    public float GeenRotatieX;

    // Update is called once per frame
    void Update()
    {
        //Bereken RotatieInput
        float XRot = (float)(Input.mousePosition.x - 0.5 * Screen.width);
        float YRot = (float)(0.5 * Screen.height - Input.mousePosition.y);

        //Pas Y rotatie aan voor gameplay smoothness
        if(YRot <= GeenRotatieY & YRot >= -GeenRotatieY)
        {
            YRot = 0;
        }
        else if(YRot > GeenRotatieY)
        {
            YRot -= GeenRotatieY;
            if(YRot > 80)
            {
                YRot = 80;
            }
        }
        else if (YRot < -GeenRotatieY)
        {
            YRot += GeenRotatieY;
            if(YRot < -80)
            {
                YRot = -80;
            }
        }

        //Pas X rotatie aan voor gameplay smoothness
        if(XRot <= GeenRotatieX & XRot >= -GeenRotatieX)
        {
            XRot = 0;
        }
        else if(XRot >  GeenRotatieX)
        {
            XRot -= GeenRotatieX;
        }
        else if(XRot < -GeenRotatieX)
        {
            XRot += GeenRotatieX;
        }
        
        //Update Camera rotatie
        Vector3 CurrentPos = Camera.rotation.eulerAngles;
        Vector3 NewPos = new Vector3(YRot, CurrentPos.y + draaisnelheid*XRot, 0);
        Camera.rotation = Quaternion.Euler(NewPos.x, NewPos.y, 0);

        //Update de Human rotatie (alleen horizontaal)
        Vector3 HumPos = Human.rotation.eulerAngles;
        Vector3 HumNewPos = new Vector3(0, HumPos.y + draaisnelheid*XRot, 0);
        Human.rotation = Quaternion.Euler(0, HumNewPos.y, 0);
    }
}
