using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBarControl : MonoBehaviour
{
    [SerializeField]
    private EnemyHP hpcomp = null;
    [SerializeField]
    private Slider hpslider;
    private int hp;

    void Start()
    {
        hp = 100; // 最大HPの値
        hpslider.value = hp; //sliderのValueの値を最大HPにする
    }


    void Update()
    {
        int EnHP = hpcomp.HP; //EnemyHP内の変数HPをEnHPとして使用
        hpslider.value = EnHP; //Valueの値をEnHPの値にする
    }
}