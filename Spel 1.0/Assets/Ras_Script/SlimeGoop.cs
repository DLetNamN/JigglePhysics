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
    public Vector2 slimeJumpLeft;
    public Vector2 slimeJumpRight;

    // Start is called before the first frame update
    void Start()
    {
        Target = GameObject.FindWithTag("Player");
        rBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var targetPos = Target.GetComponent<Transform>();

        TargetDistance = targetPos.position.x - gameObject.transform.position.x;
    
        if (TargetDistance >= 0.5)
            WhereToLook = true;

        if (TargetDistance <= -0.5)
            WhereToLook = false;

        if (WhereToLook == false && HowManyJump < 3 && goopCheck.goopOnGround == true || Input.GetKey(KeyCode.H))
        {
            rBody.AddForce(slimeJumpLeft);
            HowManyJump = HowManyJump + 1;
        }
        else if (WhereToLook == false && HowManyJump >= 3 && goopCheck.goopOnGround == true || Input.GetKey(KeyCode.H))
        {
            rBody.AddForce(slimeJumpLeft * 2);
            HowManyJump = 0;
        }

        if (WhereToLook == true && HowManyJump < 3 && goopCheck.goopOnGround == true || Input.GetKey(KeyCode.H))
        {
            rBody.AddForce(slimeJumpRight);
            HowManyJump = HowManyJump + 1;
        }
        else if (WhereToLook == true && HowManyJump >= 3 && goopCheck.goopOnGround == true || Input.GetKey(KeyCode.H))
        {
            rBody.AddForce(slimeJumpRight * 2);
            HowManyJump = 0;
        }
    }
}
