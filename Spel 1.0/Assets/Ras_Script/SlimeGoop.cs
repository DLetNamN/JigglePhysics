using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeGoop : MonoBehaviour
{
    public GoopCheck goopCheck;
    public Rigidbody2D rBody;
    public GameObject Target;
    public float TargetDistance;

    public bool WhereToLook;
    public int jumpsToBig;
    public int HowManyJump;
    public Vector2 slimeJump;
    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        TargetDistance = Target.transform.position.x - transform.position.x;
        if (TargetDistance >= 1.3)
            WhereToLook = true;

        if (TargetDistance <= -1.3)
            WhereToLook = false;

        if (WhereToLook == false && HowManyJump < 3 && goopCheck.goopOnGround == true || Input.GetKey(KeyCode.H))
        {
            rBody.AddForce(slimeJump);
            HowManyJump = HowManyJump + 1;
             
        }
        else if (WhereToLook == false && HowManyJump >= 3 && goopCheck.goopOnGround == true || Input.GetKey(KeyCode.H))
        {
            rBody.AddForce(slimeJump * 2);
            HowManyJump = 0;
            
        }

        if (WhereToLook == true && HowManyJump < 3 && goopCheck.goopOnGround == true || Input.GetKey(KeyCode.H))
        {
            rBody.AddForce(slimeJump);
            HowManyJump = HowManyJump + 1;
            
        }
        else if (WhereToLook == true && HowManyJump >= 3 && goopCheck.goopOnGround == true || Input.GetKey(KeyCode.H))
        {
            rBody.AddForce(slimeJump * 2);
            HowManyJump = 0;
            
            
        }
    }

}
