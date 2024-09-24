using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forklift : MonoBehaviour
{
    [SerializeField] Transform lift;
    [SerializeField] float minY;
    [SerializeField] float maxY;
    [SerializeField] float speed;
    void Start()
    {
        
    }

    void Update()
    {
        int direction = Input.GetKey(KeyCode.E) ? 1 : Input.GetKey(KeyCode.Q) ? -1 : 0;

        lift.localPosition += Vector3.up * speed * Time.deltaTime * direction;
        //lift.localPosition = new Vector3(0, Mathf.Clamp(lift.position.y, minY, maxY), lift.localPosition.z);
    }
}
