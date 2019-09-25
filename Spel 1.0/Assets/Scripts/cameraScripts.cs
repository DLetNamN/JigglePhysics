using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 cameraOffset = new Vector3(3, 3.6f, -10);
    public Transform cameraTransform;
    public GameObject playerObject;

    public void cameraFeedback()
    {

    }

    void Start()
    {
        playerObject = GameObject.FindWithTag("Player");
        playerTransform = playerObject.GetComponent<Transform>();
        cameraTransform = GetComponentInParent<Transform>();
    }

    void Update()
    {
        playerTransform = playerObject.GetComponent<Transform>();
        cameraTransform.position = new Vector3(playerTransform.position.x, playerTransform.position.y + cameraOffset.y, playerTransform.position.y + cameraOffset.z);
    }
}
