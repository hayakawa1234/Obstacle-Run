using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereObject : MoveBoxBase
{
    //特定のアニメーションが当たった場合の処理
    void Update()
    { 
        //丸いオブジェクトが回転するようにする
        Transform sphereTransform = this.transform;
        sphereTransform.Rotate(1.0f, 1.0f, 1.0f, Space.World);
    }

    public void OnTriggerEnter(Collider other)
    {
        //ダメージを受けた場合に処理が行われる
        Damager damager = other.GetComponent<Damager>();
        if (damager != null)
        {
            Damage(damager.damage);

            //hpが0になった時に丸いオブジェクトが大きくなる処理
            if (hp <= 0)
            {
                this.transform.localScale = new Vector3(4, 4, 4);
            }

            //大きくなったときに飛ばせるようにする処理
            Rigidbody rb = GetComponent<Rigidbody>();
            Vector3 force = new Vector3(3.0f, 3.0f, 3.0f);
            rb.AddForce(force, ForceMode.Impulse);
        }
    }
}
