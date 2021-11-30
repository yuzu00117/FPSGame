using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    // 座標保存用
    Vector3 pos;
    // テレポート判定用
    bool isTeleport = false;
    public GameObject obj;
    GameObject TeleObj;
    // 接地判定用
    private CharacterController CharacterController;

    // Start is called before the first frame update
    void Start()
    {
        CharacterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if ( CharacterController.isGrounded )
        {
            if ( Input.GetKeyDown( KeyCode.F ) && isTeleport == false )
            {
                // 現在座標の保存
                pos = gameObject.transform.position;
                isTeleport = true;
                TeleObj = (GameObject)Instantiate ( obj, pos, Quaternion.identity );
            }
        }
        if  ( Input.GetKeyDown( KeyCode.R ) && isTeleport == true )
        {
            // CharacterControllerの無効化
            this.GetComponent<CharacterController>().enabled = false;
            // 元いた座標にテレポート
            this.gameObject.transform.position = pos;
            // CharacterControllerの有効化
            this.GetComponent<CharacterController>().enabled = true;
            isTeleport = false;        
            Destroy( TeleObj );
        }
    }
}
