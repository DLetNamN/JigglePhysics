﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartScript : MonoBehaviour
{
    public int heartPoint;
    public PlayerHP playerHealth;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
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