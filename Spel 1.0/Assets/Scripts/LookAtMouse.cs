using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMouse : MonoBehaviour
{
    public float offset;
    public GameObject Bullet;
    public Transform ShotPoint;
    public float TimeBtwShots;
    public float StartTimeBtwShots;
    private AudioManager audioManager;

    private void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);

        if (TimeBtwShots <= 0)
        {
            if (Input.GetMouseButton(0) && TimeBtwShots <= 0)
            {
                Instantiate(Bullet, ShotPoint.position, transform.rotation);
                TimeBtwShots = StartTimeBtwShots;
                FindObjectOfType<AudioManager>().Play("ShootingSound");
                
            }
        }
        
        else if (TimeBtwShots > 0)
        {
            TimeBtwShots = TimeBtwShots - Time.deltaTime;
        }
    }
}
