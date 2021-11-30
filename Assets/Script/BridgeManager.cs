using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeManager : MonoBehaviour
{
    // 通路とドアのオブジェクト格納用
    public GameObject TopBridgeObj, BottomBridgeObj, Door1, Door2;
    // ドアコライダー格納用
    public BoxCollider Door1Collider, Door2Collider;
    // ドアの開閉判定用
    bool IsDoorOpen = false;


    // Start is called before the first frame update
    void Start()
    {
        // null
    }

    // Update is called once per frame
    void Update()
    {
        // null
    }

    // 的にヒット
    void OnTriggerEnter( Collider other )
    {
        // ヒットしたものが弾で、ドアが閉じていたら
        if ( other.CompareTag( "Bullet" ) && IsDoorOpen == false )
        {
            // TopBridgeをfalseに、BottomBridgeをtrueにする
            TopBridgeObj.SetActive( false );
            BottomBridgeObj.SetActive( true );
            // Door1, Door2を開ける
            DoorOpen();
            IsDoorOpen = true;
        }
        else if ( other.CompareTag( "Bullet" ) && IsDoorOpen == true )
        {
            // TopBridgeをtrueに、BottomBridgeをfalseにする
            TopBridgeObj.SetActive( true );
            BottomBridgeObj.SetActive( false );
            gameObject.GetComponent<Renderer>().material.color = Color.red;
            gameObject.GetComponent<Renderer>().material.SetColor( "_EmissionColor", Color.red );
            // ドアを閉じる
            IsDoorOpen = false;
        }
    }

    // ドア開閉用関数
    void DoorOpen()
    {
        // ドア1とドア2を開く
        Door1.SetActive( false );
        Door2.SetActive( false );
        Door1Collider.enabled = false;
        Door2Collider.enabled = false;
        // BridgeTargetの色をgreenに変更
        gameObject.GetComponent<Renderer>().material.color = Color.green;
        gameObject.GetComponent<Renderer>().material.SetColor( "_EmissionColor", Color.green );
    }
    public void BridgeReset()
    {
        // ドアを閉じる
        Door1.SetActive( true );
        Door2.SetActive( true );
        Door1Collider.enabled = true;
        Door2Collider.enabled = true;
        // 橋のリセット
        TopBridgeObj.SetActive( true );
        BottomBridgeObj.SetActive( false );
        // BridgeTargetの色を赤に変更
        gameObject.GetComponent<Renderer>().material.color = Color.red;
        gameObject.GetComponent<Renderer>().material.SetColor( "_EmissionColor", Color.red );
        IsDoorOpen = false;
    }
}