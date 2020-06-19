using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBox : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("ぶつかったよ");
    }
}
