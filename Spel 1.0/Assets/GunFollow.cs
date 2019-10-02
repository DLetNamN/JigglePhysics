using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFollow : MonoBehaviour
{
    public GameObject playerFollow;
    public Vector3 offset;

    private void Update()
    {
        transform.position = playerFollow.transform.position + offset;
    }
}
