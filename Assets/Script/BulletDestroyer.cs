using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroyer : MonoBehaviour 
{
    void OnTriggerEnter(Collider other)
    {
        // もしもぶつかってきたオブジェクトのタグに「Bullet」という名前がついていたら
        if (other.CompareTag("Bullet"))
        {
            // ぶつかってきたオブジェクトを破壊（削除）せよ。
            Destroy(other.gameObject);
        }
    }
}
