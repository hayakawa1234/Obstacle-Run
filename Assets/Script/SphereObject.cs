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

    public override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
        this.transform.localScale = new Vector3(4, 4, 4);
        Rigidbody rb = GetComponent<Rigidbody>();
        Vector3 force = new Vector3(5.0f, 5.0f, 5.0f);
        rb.AddForce(force, ForceMode.Impulse);
    }
}
