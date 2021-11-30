using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    public GameObject bulletPrefab;
    public float ShotSpeed;

    void Update()
    {
        if ( Input.GetKeyDown( KeyCode.Mouse0 ) )
        {
            ShotBullet();
        }
    }

    void ShotBullet()
    {
        GameObject Bullet = (GameObject)Instantiate(bulletPrefab, transform.position, Quaternion.Euler(transform.parent.eulerAngles.x, transform.parent.eulerAngles.y, 0));
        Rigidbody bulletRb = Bullet.GetComponent<Rigidbody>();
        bulletRb.AddForce(transform.forward * ShotSpeed);

        // 射撃されてから三秒後に弾を削除
        Destroy( Bullet, 3.0f );
    }
}