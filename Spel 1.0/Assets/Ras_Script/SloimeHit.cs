using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SloimeHit : MonoBehaviour
{
    public int sloimeHealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(sloimeHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            sloimeHealth =- 1 ;
        }
    }
}
