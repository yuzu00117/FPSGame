using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadArea : MonoBehaviour
{

    GameObject PlayerObj;
    GameObject ResetObj;

    // Start is called before the first frame update
    void Start()
    {
        ResetObj = GameObject.Find( "Stage3Manager" );
        PlayerObj = GameObject.FindWithTag( "Player" );
    }

    // Update is called once per frame
    void Update()
    {
        // null
    }

    // 即死エリアに落ちたら
    void OnTriggerEnter( Collider other )
    {
        if ( other.CompareTag ( "Player" ) )
        {
            // キャラクターをステージ前にテレポート
            PlayerObj.GetComponent<CharacterController>().enabled = false;
            PlayerObj.transform.position = new Vector3( 0, 2.1f, 31 );
            PlayerObj.GetComponent<CharacterController>().enabled = true;
            // ステージのギミックをリセット
            ResetObj.GetComponent<Stage3Reset>().StageReset();
        }
    }
}
