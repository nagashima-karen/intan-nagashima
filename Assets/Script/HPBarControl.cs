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
    [SerializeField]
    private int hp;

    void Start()
    {
        hpslider.value = hp; //sliderのValueの値を最大HPにする
    }

    void Update()
    {
        int EnemyHP = hpcomp.HP; //EnemyHP内の変数HPをEnemyHPとして使用
        hpslider.value = EnemyHP; //Valueの値をEnemyHPの値にする
    }
}