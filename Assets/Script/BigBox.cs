using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBox : MoveBoxBase
{
    //特定のアニメーションが当たった場合の処理
    public override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
        Rigidbody rb = GetComponent<Rigidbody>();
        Vector3 force = new Vector3(10.0f, 10.0f, 10.0f);
        rb.AddForce(force, ForceMode.Impulse);
    }
}
