using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerManager : MonoBehaviour
{
    Rigidbody rb;
    Rigidbody rbody;
    Animator animator;
    float x;
    float z;
    public float moveSpeed = 2;
    [SerializeField] private Vector3 localGravity;
    public Collider weaponCollider;
    [SerializeField]
    private Transform charaRay;
    [SerializeField]
    private float charaRayRange = 0.2f;
    private bool isGround;
    private bool isGroundCollider = false;
    private Vector3 velocity;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rbody = this.GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotation;　//旋回などをしないようにする
        animator = GetComponent<Animator>();
        rbody.useGravity = false;
        HideColliderWeapon();　//初期設定では剣が当たっても何も起こらないようにする
        velocity = Vector3.zero;
        isGround = false;

    }

    void Update()
    {
        //キーボード入力で移動
        x = Input.GetAxisRaw("Horizontal");
        z = Input.GetAxisRaw("Vertical");

        //攻撃入力:Mボタンを押したら 
        if (Input.GetKeyDown(KeyCode.M))
        {
            animator.SetTrigger("attack");

            //攻撃入力：Nボタンを押したら
        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            animator.SetTrigger("attack2");

            //攻撃入力：Jボタンを押したら
        }
        else if (Input.GetKeyDown(KeyCode.J))
        {
            animator.SetTrigger("attack3");

            //攻撃入力：Spaceボタンを押したら
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("jump");
        }
        
        //地面に接地していない場合
        if (!isGroundCollider)
        {
            if (Physics.Linecast(charaRay.position, (charaRay.position - transform.up * charaRayRange)))
            {
                isGround = true;
                rb.useGravity = true;
            }
            else
            {
                isGround = false;
                rb.useGravity = false;
            }
            Debug.DrawLine(charaRay.position, (charaRay.position - transform.up * charaRayRange), Color.red);
        }
        //　キャラクターコライダが接地、またはレイが地面に到達している場合
        if (isGroundCollider || isGround)
        {
            //　地面に接地してる時は初期化
            if (isGroundCollider)
            {
                velocity = Vector3.zero;

                //　レイを飛ばして接地確認の場合は重力だけは働かせておく、前後左右は初期化
            }
            else
            {
                velocity = new Vector3(0f, velocity.y, 0f);
            }

            

            if (!isGroundCollider && !isGround)
            {
                velocity.y += Physics.gravity.y * Time.deltaTime;
            }
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

    //キャラクターにのみ重力設定をする処理
    private void SetLocalGravity()
    {
        rbody.AddForce(localGravity, ForceMode.Acceleration);
    }

    //特定のアニメーションが実行されていない場合
    public void HideColliderWeapon()
    {
        weaponCollider.enabled = false;
    }

    //特定のアニメーションが実行されている場合
    public void ShowColliderWeapon()
    {
        weaponCollider.enabled = true;
    }
}


