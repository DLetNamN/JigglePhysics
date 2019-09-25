using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goopShoot : MonoBehaviour
{

    private float goopDropHowOften = 0.75f;
    private float goopDroptimer;
    public GameObject gooopDropplet;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        goopDroptimer -= Time.deltaTime;
        if (goopDroptimer <= 0f)
        {
            Instantiate(gooopDropplet, transform.position, Quaternion.identity);
            goopDroptimer = goopDropHowOften;
        }
    }
}
