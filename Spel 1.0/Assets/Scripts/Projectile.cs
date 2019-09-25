using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float Speed;
    public float lifeTime;
    public GameObject BulletTrajectory;
    private Rigidbody2D rb;
    public Vector2 forceForward;

    private void Start()
    {
        //Invoke("DestroyProjectile", lifeTime); 
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        forceForward = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        rb.AddForce(-transform.up  * Speed);
        lifeTime -= Time.deltaTime;

        if(lifeTime <= 0)
        {
            Destroy(gameObject);
        }
    }
}
