using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MoveBoxBase
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
                Destroy(this.gameObject);
            }
        }
    }
}
