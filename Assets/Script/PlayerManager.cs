using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{   
    //Rigidbodyの変数rbの宣言
    Rigidbody rb;
    float x;
    float z;
    public float moveSpeed = 2;
    void Start()
    {
        //Rigidbodyの値を取得
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //キーボード入力で移動
        x = Input.GetAxisRaw("Horizontal");
        z = Input.GetAxisRaw("Vertical");

 

    }

    private void FixedUpdate()
    {
        //速度設定
        rb.velocity = new Vector3(x, 0, z) * moveSpeed;
    }
}
