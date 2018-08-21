using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBarControl : MonoBehaviour
{
    
    GameObject Enemy;
    EnemyHP hpcomp;
    Slider hpslider;
    private int hp;

    void Start()
    {

        Enemy = GameObject.Find("Enemy");
        hpcomp = Enemy.GetComponent<EnemyHP>();

        hpslider = GameObject.Find("HPBarControl").GetComponent<Slider>();
        hp = 100; // 最大HPの値
        hpslider.value = hp; //sliderのValueの値を最大HPにする
    }


    void Update()
    {
        int EnHP = hpcomp.HP; //EnemyHP内の変数HPをEnHPとして使用
        hpslider.value = EnHP; //Valueの値をEnHPの値にする
    }
}