using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 cameraOffset = new Vector3(3, 3.6f, -10);
    public Transform cameraTransform;
    public GameObject playerObject;

    public Rigidbody2D playerRigidbody;
    public Vector3 playerCameraOffset;

    public void cameraMovement()
    {
        float velocityX = playerRigidbody.velocity.x;
        float velocityY = playerRigidbody.velocity.y;
        float positionX = playerTransform.position.x;
        float positionY = playerTransform.position.y;

        playerTransform = playerObject.GetComponent<Transform>();
        cameraTransform.position = new Vector3(positionX - velocityX, positionY + cameraOffset.y - velocityY, cameraOffset.z);
    }

    void Start()
    {
        playerObject = GameObject.FindWithTag("Player");
        playerTransform = playerObject.GetComponent<Transform>();
        cameraTransform = GetComponentInParent<Transform>();
    }

    void Update()
    {
        cameraMovement();   
    }
}
