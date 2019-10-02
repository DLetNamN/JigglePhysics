using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookingScript : MonoBehaviour
{
    public float Speed;
    void Update()
    {
        //aktiverar faceMouse funktionen
        FaceMouse();
    }

    void FaceMouse()
    {
        // gör så att direction bestäms utav musens position minus spelobjektets position.
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        //variabeln angle får ett värde som är lika med spelarens "direction" på y och x axeln.
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        // gör så att rotationen mellan två punkter blir mjuk. 
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        //
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Speed * Time.deltaTime);
    }

}
