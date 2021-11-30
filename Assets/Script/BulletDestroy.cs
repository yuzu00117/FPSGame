using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
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

    void OnTriggerEnter( Collider other )
    {
        if ( other.CompareTag( "Wall" ) )
        {
            Debug.Log( "壁に衝突しました" );
            Destroy( gameObject );
        }       
    }
}
