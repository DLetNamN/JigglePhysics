using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ByeGoop : MonoBehaviour
{
    public bool GoopDead;
    public Sprite Splat;
    // Update is called once per frame
    void Update()
    {
        if(GoopDead == true)
        {
            Destroy(gameObject);
        }
    }
        void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Ground")
            {

                
                GoopDead = true;
            }
        }
}
