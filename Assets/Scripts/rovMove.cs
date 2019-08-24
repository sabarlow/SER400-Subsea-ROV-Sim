using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rovMove : MonoBehaviour
{
    public GameObject character;
    public float speed;
    public float turnSpeed;

    private Rigidbody rovBody;

    // Start is called before the first frame update
    void Start()
    {
        rovBody = GetComponent<Rigidbody>();

        speed = 50f;
        turnSpeed = 1f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float thrustForward = Input.GetAxis("ThrustForward");
        float thrustRight = Input.GetAxis("ThrustRight");
        float thrustUp = Input.GetAxis("ThrustUp");

        Vector3 movement = new Vector3(thrustRight, thrustUp, thrustForward);
        rovBody.AddRelativeForce(movement * speed);

        float yaw = Input.GetAxis("Yaw");
        float pitch = Input.GetAxis("Pitch");
        Vector3 rotateMovement = new Vector3(pitch, yaw, 0);
        rovBody.AddRelativeTorque(rotateMovement * turnSpeed);

    }
}
