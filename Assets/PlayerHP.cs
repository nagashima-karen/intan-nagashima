﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{

    [SerializeField]
    private readonly int maxHP = 2000;    //体力の最大値
    public int HP;    //体力
    [SerializeField]
    private int EnemyATK = 25;  //ドラゴンの攻撃力

    void Start()
    {
        HP = maxHP; //初期体力を最大値にする
    }


    void Update()
    {
        if (HP <= 0)
        {
            Debug.Log("死亡しました");

        }
    }

    void OnTriggerEnter(Collider hit)
    {

        if (hit.CompareTag("Enemy"))
        {

            HP -= EnemyATK; //攻撃で体力が減少
            Debug.Log("プレイヤーの残りHP" + HP);

        }

    }
}