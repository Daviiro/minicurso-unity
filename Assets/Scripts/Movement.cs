using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float velocity = 0.1f;

    Rigidbody playerRigidBody;

    private void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPosition = gameObject.transform.position;

        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            playerRigidBody.AddForce(gameObject.transform.forward * velocity);
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            playerRigidBody.AddForce(gameObject.transform.forward * -1 * velocity);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            playerRigidBody.AddForce(gameObject.transform.right * -1 * velocity);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            playerRigidBody.AddForce(gameObject.transform.right * velocity);
        }
    }
}
