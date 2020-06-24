using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlowOff : MoveBoxBase
{ 
    //特定のアニメーションが当たった場合の処理
    public void OnTriggerEnter(Collider other)
    {
        Damager damager = other.GetComponent<Damager>();
        if (damager != null)
        {
            Damage(damager.damage);

            //hpが0になった時にボックスを飛ばす処理
            if (hp <= 0)
            {
                Rigidbody rb = GetComponent<Rigidbody>();
                Vector3 force = new Vector3(5.0f, 5.0f, 5.0f);
                rb.AddForce(force, ForceMode.Impulse);
            }
        }
    }

    }
