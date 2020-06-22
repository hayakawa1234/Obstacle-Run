using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBox : MonoBehaviour
{
    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void OnTriggerEnter(Collider other)
    {
        Damager damager = other.GetComponent<Damager>();
        if(damager != null)
        {
            Debug.Log("ダメージを受ける");
        }
    }
}
