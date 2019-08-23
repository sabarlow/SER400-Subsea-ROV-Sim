using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class rovMove : MonoBehaviour
{
    public GameObject character;
    public float speed;
    public float turnSpeed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
        turnSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        InputTracking.disablePositionalTracking = true;
        InputTracking.Recenter();
        if (Input.GetKey(KeyCode.W))
        {
            character.transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.Self);
            //Vector3 newPosition = 
            //newPosition.z++;
            //character.transform.position = newPosition;
        }
        if (Input.GetKey(KeyCode.S))
        {
            character.transform.Translate(Vector3.back * Time.deltaTime * speed, Space.Self);
            //Vector3 newPosition = character.transform.position;
            //newPosition.z--;
            //character.transform.position = newPosition;
        }
        if (Input.GetKey(KeyCode.A))
        {
            character.transform.Rotate(Vector3.down * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            character.transform.Rotate(-Vector3.down * Time.deltaTime * speed);
        }

        float mousePitch = Input.GetAxis("Mouse Y");
        character.transform.Rotate(Vector3.right * mousePitch);

        float mouseYaw = Input.GetAxis("Mouse X");
        character.transform.Rotate(Vector3.up * mouseYaw);
    }
}
