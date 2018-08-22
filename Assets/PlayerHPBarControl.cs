using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHPBarControl : MonoBehaviour
{
    [SerializeField]
    private PlayerHP hpcomp = null;
    [SerializeField]
    private Slider hpslider;
    private int hp;

    void Start()
    {
        hp = 2000; // 最大HPの値
        hpslider.value = hp; //sliderのValueの値を最大HPにする
    }


    void Update()
    {
        int PlHP = hpcomp.HP; //PlayerHP内の変数HPをPlHPとして使用
        hpslider.value = PlHP; //Valueの値をPlHPの値にする
    }
}