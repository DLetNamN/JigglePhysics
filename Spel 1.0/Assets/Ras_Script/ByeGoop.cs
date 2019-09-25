using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ByeGoop : MonoBehaviour
{
    public bool GoopDead;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GoopDead == true)
        {
            Destroy(gameObject);
        }
    }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Ground")
            {
                GoopDead = true;
            }
        }
}
