using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleBack : MonoBehaviour
{

    GameObject PlayerObj;

    // Start is called before the first frame update
    void Start()
    {
        PlayerObj = GameObject.FindWithTag( "Player" );
    }

    // Update is called once per frame
    void Update()
    {
        // null
    }

    void OnTriggerEnter( Collider other )
    {
        if ( other.CompareTag ( "Player" ) ) 
        {
            SceneManager.LoadScene ( "Title" );
            PlayerObj.GetComponent<CharacterController>().enabled = false;
        }
    }
}
