using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour 
{
    [SerializeField]
    private GameObject BulletPrefab = null;
    [SerializeField]
    private float shotSpeed;
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetMouseButtonDown(0)) 
            //Shotを0.5秒後に呼び出す
            Invoke("Shot", 0.5f);
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
