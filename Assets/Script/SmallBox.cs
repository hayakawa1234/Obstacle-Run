using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallBox : MoveBoxBase
{
    //特定のアニメーションが当たった場合の処理
    public void OnTriggerEnter(Collider other)
    {
        //ダメージを受けた場合に処理が行われる
        Damager damager = other.GetComponent<Damager>();
        if (damager != null)
        {
            Damage(damager.damage);

            //hpが0になった時にボックスが小さくなる処理
            if (hp <= 0)
            {
                this.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            }
        }

        //小さくなってからボックスを飛ばせるようにする
        Rigidbody rb = GetComponent<Rigidbody>();
        Vector3 force = new Vector3(10.0f, 10.0f, 10.0f);
        rb.AddForce(force, ForceMode.Impulse);
    }
}
