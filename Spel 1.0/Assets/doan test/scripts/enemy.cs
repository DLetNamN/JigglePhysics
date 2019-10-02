using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject blood;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.tag.Equals("Player"))
        {
            Instantiate(blood, transform.position, Quaternion.identity);
        }
    }   
}
