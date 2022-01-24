using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    GameObject Menu; // Menu
    GameObject Player;

    private CharacterController CharacterController;

    // Start is called before the first frame update
    void Start()
    {
        // ゲームメニューを取得
        Menu = GameObject.Find( "GameMenu" );
        Debug.Log( Menu );
        Menu.SetActive( false );

        // PLayerのCharacterControllerを取得
        Player = GameObject.FindWithTag( "Player" );
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKeyDown( KeyCode.Escape ) )
        {
            Menu.SetActive( true );
        }
    }
}
