using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MoveBoxBase
{
    //特定のアニメーションが当たった場合の処理
    public override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
        Destroy(this.gameObject);
    }
}
