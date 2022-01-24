using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3Reset : MonoBehaviour
{
    // 橋のオブジェクト格納用
    GameObject BridgeManagerObj;
    // 的のオブジェクト格納用
    GameObject Target1Obj, Target2Obj;
    // クリア判定用
    bool IsClear = false;

    // Start is called before the first frame update
    void Start()
    {
        // それぞれのオブジェクトを格納
        BridgeManagerObj = GameObject.Find( "BridgeManager" );
        Target1Obj = GameObject.Find( "Target1" );
        Target2Obj = GameObject.Find( "Target2" );

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // ステージリセット
    public void StageReset()
    {
        // ステージをリセットさせる
        if ( IsClear == false ) {
        // 橋のオブジェクトリセット
        BridgeManagerObj.GetComponent<BridgeManager>().BridgeReset();
        // ドアのオブジェクトリセット
        Target1Obj.GetComponent<Stage3DoorOpen>().DoorReset();
        Target2Obj.GetComponent<Stage3DoorOpen>().DoorReset();
        }
    }
    public void ClearStage()
    {
        IsClear = true;
    }
}
