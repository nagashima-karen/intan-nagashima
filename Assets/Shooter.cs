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
        Quaternion rote = new Quaternion(0.0f, 90.0f, 90.0f, 1.0f);
        GameObject Bullet = (GameObject)
            Instantiate(BulletPrefab,transform.position,rote
        );
        
        //BulletオブジェクトのRigidbodyを取得し力をくわえる。
        Rigidbody BulletRigidBody = Bullet.GetComponent<Rigidbody>();
        BulletRigidBody.AddForce(transform.forward * shotSpeed);
    }
}
