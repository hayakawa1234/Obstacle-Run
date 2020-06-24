using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MoveBoxBase
{
    //特定のアニメーションが当たった場合の処理
    public void OnTriggerEnter(Collider other)
    {
        //ダメージを受けた場合に処理が行われる
        Damager damager = other.GetComponent<Damager>();
        if (damager != null)
        {
            Damage(damager.damage);

            //hpが0になった時にボックスを消す処理
            if (hp <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
