using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneGravity : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float gravityMagnitude;
    bool useGyro;
    Vector3 gravityDir;
    void Start()
    {
        if (SystemInfo.supportsGyroscope)
        {
            useGyro = true;
            Input.gyro.enabled = true;
        }
    }

    void Update()
    {
        var inputDir = useGyro ? Input.gyro.gravity : Input.acceleration;

        //atur arah karena orientasi kamera berbeda dengan orientasi world game
        gravityDir = new Vector3(
            inputDir.x,
            inputDir.z,
            inputDir.y
        );
        // Debug.Log(gravityDir);
    }
    private void FixedUpdate()
    {
        //menggunakan constant acceleration krn gravity merupakan acceleration
        rb.AddForce(gravityDir * gravityMagnitude, ForceMode.Acceleration);
    }
}
