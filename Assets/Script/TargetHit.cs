using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetHit : MonoBehaviour
{
    public GameObject Door;
    public BoxCollider DoorCollider;
    public Material ExitMaterial;    
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
        if ( other.CompareTag( "Bullet" ) )
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
            gameObject.GetComponent<Renderer>().material.SetColor( "_EmissionColor", Color.green );
            Destroy( Door );
            DoorCollider.enabled = false;
        }
    }
}
