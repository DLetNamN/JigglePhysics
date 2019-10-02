using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoCounter : MonoBehaviour
{
    public Text ammoAmount;
    public LookAtMouse lam;
    void Update()
    {
        string MaxAmmo = (lam.MaxShots).ToString();
        string currentAmmo = (lam.MaxShots - lam.shotAmount).ToString();
        ammoAmount.text = MaxAmmo + "/" + currentAmmo;

        if(lam.reloadTimer > 0)
        {
            ammoAmount.text = "N/A";
        }
    }
}
