using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour 
{
    public GameObject BulletPrefab;
    public float shotSpeed;
    public float shotTorque;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetMouseButtonDown(0)) Shot();	
	}

    public void Shot ()
    {
        //プレファブからBulletオブジェクトを生成
        GameObject Bullet = (GameObject)Instantiate(
        BulletPrefab,
        transform.position,
            Quaternion.identity
        );
        //BulletオブジェクトのRigidbodyを取得し力と回転を加える
        Rigidbody BulletRigidBody = Bullet.GetComponent<Rigidbody>();
        BulletRigidBody.AddForce(transform.forward * shotSpeed);

    }
}
