using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float speed;
    [SerializeField] float rotationRate;
    void Start()
    {
        
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        if (v != 0)
        {
            rb.AddForce((transform.right * h * .5f + transform.forward * v) * speed);

            if (h != 0)
            {
                int mult = v > 0 ? 1 : -1;
                transform.eulerAngles += Vector3.up * rotationRate * h * Time.deltaTime * mult;
            }
        }
    }
}
