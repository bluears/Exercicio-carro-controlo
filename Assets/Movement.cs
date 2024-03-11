using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 20.0f;
    public float SlowSpeed = 10.0f;
    public Vector3 rotateL = new Vector3(0, -75, 0);
    public Vector3 rotateR = new Vector3(0, 75, 0);
    Rigidbody rig;
    public float magnitude = 5;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //currentPosition = Transform.position;
        //currentPosition.z += .05f;
        //transform.position = currentPosition;

        //transform.Translate(0, 0, .05f);
        //transform.Translate(Vector3.fwd * speed * Time.deltaTime);
        rig.AddForce(Vector3.fwd * magnitude * Time.deltaTime);
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.fwd * speed * Time.deltaTime);
            Debug.Log("W key down");
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.fwd * SlowSpeed * Time.deltaTime);

            Debug.Log("S key down");
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(rotateR * Time.deltaTime);
            Debug.Log("D key down");
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(rotateL * Time.deltaTime);
            Debug.Log("A key down");
        }
    }
}
