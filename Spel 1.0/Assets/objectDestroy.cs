using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectDestroy : MonoBehaviour
{

    public ParticleSystem slimeDeathParticles;
    public Vector3 slimeOffset;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Instantiate(slimeDeathParticles, transform.position + slimeOffset, slimeDeathParticles.transform.rotation);
            print("Bullet hit!");
            FindObjectOfType<AudioManager>().Play("SlimeDeath");
            Destroy(gameObject);
        }
    }
}
