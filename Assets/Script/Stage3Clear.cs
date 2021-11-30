using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3Clear : MonoBehaviour
{
    GameObject StageManager;

    // Start is called before the first frame update
    void Start()
    {
        StageManager = GameObject.Find( "Stage3Manager" );
        Debug.Log( StageManager );
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // クリアしたらStage3Resetを停止
    void OnTriggerEnter( Collider other )
    {
        if ( other.CompareTag( "Player" ) )
        {
            StageManager.GetComponent<Stage3Reset>().ClearStage();
        }
    }
}
