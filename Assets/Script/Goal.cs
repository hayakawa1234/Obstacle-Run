using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public static bool goal;
    void Start()
    {
        goal = false;
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            goal = true;
        }
    }
}
