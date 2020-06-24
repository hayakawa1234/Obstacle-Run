using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBox : MoveBoxBase
{
    //特定のアニメーションが当たった場合の処理
    public void OnTriggerEnter(Collider other)
    {
        //ダメージを受けた場合に処理が行われる
        Damager damager = other.GetComponent<Damager>();
        if (damager != null)
        {
            Damage(damager.damage);

            //hpが0になった時にボックスが大きくなる
            if (hp <= 0)
            {
                this.transform.localScale = new Vector3(4, 4, 4);
            }

            //大きくなってからボックスを飛ばせるようにする
            Rigidbody rb = GetComponent<Rigidbody>();
            Vector3 force = new Vector3(3.0f, 3.0f, 3.0f);
            rb.AddForce(force, ForceMode.Impulse);
        }
    }
}
