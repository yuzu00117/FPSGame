using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDestroyObj : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update () {

    }
    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("衝突したオブジェクト：" + gameObject.name);
        Debug.Log("衝突されたオブジェクト：" + collision.gameObject.name);

        Destroy(gameObject);
    }
}