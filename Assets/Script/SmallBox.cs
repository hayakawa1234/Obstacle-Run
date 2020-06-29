using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallBox : MoveBoxBase
{   

    //特定のアニメーションが当たった場合の処理
    public override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
        Instantiate(particleObject, this.transform.position, Quaternion.identity);
        this.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        Rigidbody rb = GetComponent<Rigidbody>();
        Vector3 force = new Vector3(5.0f, 5.0f, 5.0f);
        rb.AddForce(force, ForceMode.Impulse);
    }
}
