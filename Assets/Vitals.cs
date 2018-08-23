using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vitals : MonoBehaviour
{
    [SerializeField]
    private EnemyHP enemyHP;
    [SerializeField]
    private int damage = 200;  //プレイヤーの攻撃力
 
    void OnTriggerEnter(Collider hit)
    {
        if (hit.CompareTag("Bullet"))
        {
            enemyHP.HP -= damage; //攻撃で体力が減少
            Debug.Log("急所に当たった!!" + enemyHP);
        }
    }
}