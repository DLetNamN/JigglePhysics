using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartScript : MonoBehaviour
{
    public int heartPoint;
    public PlayerHP playerHealth;

    void Start()
    {

    }

    void Update()
    {
        if (playerHealth.playerHP < heartPoint)
        {
            gameObject.SetActive(false);
        }

        if(playerHealth.playerHP > heartPoint)
        {
            gameObject.SetActive(true);
        }
    }
}
