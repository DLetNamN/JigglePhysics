using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    //public GameObject healthbar;
    public int playerHP = 3;
    public Slider healthbarslider;

    public void Start()
    {
        healthbarslider.value = playerHP;
    }

    void Update()
    {
        if (playerHP <= 0)
        {
            SceneManager.LoadScene("DeathScreen");
        }

        healthbarslider.value = playerHP;

    }

    public void OnCollisionEnter2D(Collision2D _collision)
    {
        if (_collision.gameObject.tag == "Enemy")
        {
            DamagePlayer();
        }

        if (_collision.gameObject.tag == "Heal")
        {
            HealPlayer();
        }
    }


    public void DamagePlayer()
    {
        playerHP -= 1;
        Debug.Log("Damage acquired");
    }

    public void HealPlayer()
    {
        playerHP += 1;

        if (playerHP >= 3)
        {
            playerHP = 3;
        }
        Debug.Log("HP acquired");
    }

}
