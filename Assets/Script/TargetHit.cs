using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetHit : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        //null
    }

    // Update is called once per frame
    void Update()
    {
        //null
    }

    void OnTriggerEnter( Collider other )
    {
        Debug.Log( "何かが衝突しました" );
        gameObject.GetComponent<Renderer>().material.color = Color.green;
    }
}
