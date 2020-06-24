﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBox : MoveBoxBase
{
    public void OnTriggerEnter(Collider other)
    {
        Damager damager = other.GetComponent<Damager>();
        if (damager != null)
        {
            Damage(damager.damage);

            //hpが0になった時にボックスを飛ばす処理
            if (hp <= 0)
            {
                this.transform.localScale = new Vector3(4, 4, 4);
            }

            Rigidbody rb = GetComponent<Rigidbody>();
            Vector3 force = new Vector3(3.0f, 3.0f, 3.0f);
            rb.AddForce(force, ForceMode.Impulse);
        }
    }
}
