using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    private Rigidbody rb;    // Rigidbody用変数
    private bool IsGrounded;  // 接地判定用変数
    public float JumpPower; // ジャンプの力

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // PlayerについたRigidBodyを取得して格納
    }

    // Update is called once per frame
    void Update()
    {
        if ( IsGrounded == true ) // 地面に接地しているかつ
        {
            if ( Input.GetKeyDown( KeyCode.Space ) )// スペースキーが押されたら
            {
                IsGrounded = false; // IsGroundedをfalseにする
                rb.AddForce( Vector3.up * JumpPower ); // 上にJumpPower分跳ぶ
            }
        }
    }

    void OnCollisionEnter( Collision other ) // 地面に触れた時用
    {
        if ( other.gameObject.tag == "Ground" ) // Groundのタグがついたオブジェクトに触れたら
        {
            IsGrounded = true; // Groundedをtrueに
        }
    }
}