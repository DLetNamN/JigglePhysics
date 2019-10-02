using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Animations;

public class GoopAqush : MonoBehaviour
{
    public SlimeGoop slimeGoop;
    public float SquishTimer;
    public int SquishJump;
    public Animator Squish;
    // Start is called before the first frame update
    void Start()
    {
        Squish = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SquishJump == 1 && slimeGoop.goopSquish)
        {
            Squish.SetInteger("SquishAnim", 1);
        }
        else
        {
            Squish.SetInteger("SquishAnim", 0);
        }

        if (SquishTimer <= 0.3)
        {
            SquishJump = 1;
        }
        else
            SquishJump = 0;

        SquishTimer += Time.deltaTime;
    }
}
