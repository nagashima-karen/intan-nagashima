using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBarCtrl : MonoBehaviour {

    public readonly int maxHP = 1000;    //体力の最大値
    public int HP;    //体力
    public int EnemyATK = 10;  //自分の攻撃力

    void Start()
    {
        HP = maxHP; //初期体力を最大値にする
    }

	
	// Update is called once per frame
	void Update () {

	}
    void OnTriggerEnter(Collider hit)
    {

        if (hit.CompareTag("Bullet"))
        {

            HP -= EnemyATK; //攻撃で体力が減少
        }
    }
}
