using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rovJaw : MonoBehaviour
{
    Vector3 rotationVector;

    // Start is called before the first frame update
    void Start()
    {
        rotationVector.x = 0f;
        rotationVector.y = 0f;
        rotationVector.z = 0f;

    }

    // Update is called once per frame
    void Update()
    {
        rotationVector.x = Input.GetAxis("Fire1");
        transform.Rotate(rotationVector);
    }
}
