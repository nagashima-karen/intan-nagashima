﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHP : MonoBehaviour
{


    public readonly int maxHP = 1000;    //体力の最大値
    public int HP;    //体力
    public int PlayerATK = 10;  //プレイヤーの攻撃力
    [SerializeField]
     private Animator animator;


    void Start()
    {
        HP = maxHP; //初期体力を最大値にする
    }


    void Update()
    {
        if (HP <= 0)
        {
            Debug.Log("倒しました");
            SceneManager.LoadScene("Clear");
        }
    }

    void OnTriggerEnter(Collider hit)
    {

        if (hit.CompareTag("Bullet"))
        {

            HP -= PlayerATK; //攻撃で体力が減少
            Debug.Log("残りHP" + HP);
            animator.SetTrigger("Get Hit");
        }

    }
}