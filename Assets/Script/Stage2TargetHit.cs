using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2TargetHit : MonoBehaviour
{
    // タイマー用関数
    float countTime = 0;
    bool TimerON = false;
    // 的の衝突判定用
    public GameObject Door;
    public BoxCollider DoorCollider;
    public Material ExitMaterial;    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( TimerON == true )
        {
            countTime += Time.deltaTime;
            gameObject.GetComponent<Renderer>().material.color = Color.green;
            gameObject.GetComponent<Renderer>().material.SetColor( "_EmissionColor", Color.green );
            Door.SetActive( false );
            DoorCollider.enabled = false;
        }
        if( countTime >= 5 )
        {
            TimerON = false;
            gameObject.GetComponent<Renderer>().material.color = Color.red;
            gameObject.GetComponent<Renderer>().material.SetColor( "_EmissionColor", Color.red );
            countTime = 0;
            Door.SetActive( true );
            DoorCollider.enabled = true;
        }
    }

    // target に弾が当たったら
    void OnTriggerEnter( Collider other )
    {
        if ( other.CompareTag( "Bullet" ) && TimerON == false )
        {
            // タイマーをオン
            TimerON = true;
        }
    }
}
