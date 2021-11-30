using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3DoorOpen : MonoBehaviour
{
    public GameObject Door;
    public BoxCollider DoorCollider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // 的にヒット
    void OnTriggerEnter( Collider other )
    {
        // ヒットしたものが弾だった場合
        if ( other.CompareTag( "Bullet" ) )
        {
            Door.SetActive( false );
            DoorCollider.enabled = false;
            gameObject.GetComponent<Renderer>().material.color = Color.green;
            gameObject.GetComponent<Renderer>().material.SetColor( "_EmissionColor", Color.green );
        }
    }
    // ドアのリセット
    public void DoorReset()
    {
        Door.SetActive( true );
        DoorCollider.enabled = true;
        gameObject.GetComponent<Renderer>().material.color = Color.red;
        gameObject.GetComponent<Renderer>().material.SetColor( "_EmissionColor", Color.red );
    }
}
