using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoopTurn : MonoBehaviour
{
    public SlimeGoop slimeGoop;

    public Transform slimeTransform;

    // Start is called before the first frame update
    void Start()
    {
        slimeTransform = GetComponentInParent<Transform>();    
    }

    // Update is called once per frame
    void Update()
    {
        if(slimeGoop.WhereToLook == true)
        {
            slimeTransform.localEulerAngles = new Vector3(0f, 0f, -180f);
        }
        else
        {
            slimeTransform.localEulerAngles = new Vector3(0f, 180f, -180f);
        }
    }
}
