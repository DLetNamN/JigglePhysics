using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    public Transform playerTransform;
    public Transform cameraTransform;
    public GameObject playerObject;

    public Rigidbody2D playerRigidbody;
    public Vector3 playerCameraOffset;
    public float cameraSpeed = 1.0f;

    public void cameraVariables()
    {
        playerObject = GameObject.FindWithTag("Player");
        playerTransform = playerObject.GetComponent<Transform>();
        cameraTransform = GetComponentInParent<Transform>();
        playerRigidbody = playerObject.GetComponent<Rigidbody2D>();
        playerCameraOffset = new Vector3(0, 0, -10);
    }

    public void Start()
    {
        cameraVariables();
    }

    public void cameraFollow()
    {
        Vector3 playerTransf = playerTransform.position;

        Vector3 DesiredPosition = playerTransf + playerCameraOffset;

        cameraTransform.position = Vector3.Lerp(playerTransf + playerCameraOffset, DesiredPosition, cameraSpeed);
    }

    public void FixedUpdate()
    {
        cameraFollow();
    }
}
