﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerManager : MonoBehaviour
{
    //Rigidbodyの変数rbの宣言
    AnimatorStateInfo animatorStateInfo;
    Rigidbody rb;
    Rigidbody rbody;
    Animator animator;
    float x;
    float z;
    public float moveSpeed = 2;
    [SerializeField] private Vector3 localGravity;

    void Start()
    {
        //Rigidbodyの値を取得
        rb = GetComponent<Rigidbody>();
        rbody = this.GetComponent<Rigidbody>();
        //旋回などをしないようにする
        rb.constraints = RigidbodyConstraints.FreezeRotation;
        animator = GetComponent<Animator>();
        rbody.useGravity = false;
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

        //攻撃入力：Nボタンを押したら
        } else if(Input.GetKeyDown(KeyCode.N))
        {
            animator.SetTrigger("attack2");

        //攻撃入力：Jボタンを押したら
        } else if(Input.GetKeyDown(KeyCode.J))
        {
            animator.SetTrigger("attack3");

        //攻撃入力：Spaceボタンを押したら
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
        SetLocalGravity();
    }

    public void Hit()
    {
        
    }

    private void SetLocalGravity()
    {
        rbody.AddForce(localGravity, ForceMode.Acceleration);
    }

    public void OnTriggerEnter(Collider other)
    {
        Damager damager = other.GetComponent<Damager>();
        if (damager != null)
        {
            Debug.Log("ダメージを受ける");
        }
    }


}


