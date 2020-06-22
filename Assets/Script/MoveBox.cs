using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBox : MonoBehaviour
{
    Rigidbody rb;
    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }
    public void OnTriggerEnter(Collider other)
    {
        Damager damager = other.GetComponent<Damager>();
        if(damager != null)
        {
            Vector3 force = new Vector3(0.0f, 8.0f, 1.0f);
            rb.AddForce(force, ForceMode.Impulse);
        }
    }
}
