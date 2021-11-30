using System.Collections.Generic;
using UnityEngine;
 
public class PlayerController : MonoBehaviour
{
    public float mainSPEED;
    public float DashSpeed;
    void Start()
    {
        Cursor.visible = false;      
    }
 
    void Update()
    {
        if ( Input.GetKey( KeyCode.LeftShift ) )
        {
            Debug.Log( "Shiftキーが押されています" );
            Transform　trans = transform;
            transform.position = trans.position;
            trans.position += trans.TransformDirection(Vector3.forward) * Input.GetAxis("Vertical") * DashSpeed;
            trans.position += trans.TransformDirection(Vector3.right) * Input.GetAxis("Horizontal") * DashSpeed;
        }
        else
        {
            Transform　trans = transform;
            transform.position = trans.position;
            trans.position += trans.TransformDirection(Vector3.forward) * Input.GetAxis("Vertical") * mainSPEED;
            trans.position += trans.TransformDirection(Vector3.right) * Input.GetAxis("Horizontal") * mainSPEED;
        }
    }
}