using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{   
    //Rigidbodyの変数rbの宣言
    Rigidbody rb;
    Animator animator;
    float x;
    float z;
    public float moveSpeed = 2;
    void Start()
    {
        //Rigidbodyの値を取得
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //キーボード入力で移動
        x = Input.GetAxisRaw("Horizontal");
        z = Input.GetAxisRaw("Vertical");

        //攻撃入力:Mボタンを押したら 
        if(Input.GetKeyDown(KeyCode.M))
        {
            animator.SetTrigger("attack");
        } else if(Input.GetKeyDown(KeyCode.N))
        {
            animator.SetTrigger("attack2");
        } else if(Input.GetKeyDown(KeyCode.J))
        {
            animator.SetTrigger("attack3");
        } else if(Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("jump");
        }

    }

    private void FixedUpdate()
    {   
        //方向転換
        Vector3 direction = transform.position + new Vector3(x, 0, z) * moveSpeed;
        transform.LookAt(direction);
        //速度設定
        rb.velocity = new Vector3(x, 0, z) * moveSpeed;
        animator.SetFloat("speed", rb.velocity.magnitude);
    }
}
