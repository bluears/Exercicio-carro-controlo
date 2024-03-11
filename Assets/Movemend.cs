using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movemend: MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public float m_Thrust = 20f;

void Start()
{
    //Fetch the Rigidbody from the GameObject with this script attached
    m_Rigidbody = GetComponent<Rigidbody>();
}

void Update()
{
    if (Input.GetKey(KeyCode.J))
    {
        //Apply a force to this Rigidbody in direction of this GameObjects up axis
        m_Rigidbody.AddForce(transform.up  * m_Thrust);
    }
}
}

// Update is called once per frame