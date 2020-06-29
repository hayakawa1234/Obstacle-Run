﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlowOff : MoveBoxBase
{
    public GameObject particleObject;
    //特定のアニメーションが当たった場合の処理
    public override void OnTriggerEnter(Collider other)
    {
        Instantiate(particleObject, this.transform.position, Quaternion.identity); 
        Rigidbody rb = GetComponent<Rigidbody>();
        Vector3 force = new Vector3(0.0f, 5.0f, 5.0f);
        rb.AddForce(force, ForceMode.Impulse);
    }

}
