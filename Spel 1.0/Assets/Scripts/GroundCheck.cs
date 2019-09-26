using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public bool grounded;
    public int maxjumps = 2;
    public Movement movement;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            movement.jumps = maxjumps;
            grounded = true;
        }
    }

    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    if (collision.tag == "Ground")
    //    {
    //        touches--;
    //    }
    //}


}
