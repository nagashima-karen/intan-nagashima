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
    [SerializeField]
    private int hp;

    void Start()
    {
        hpslider.value = hp; //sliderのValueの値を最大HPにする
    }

    void Update()
    {
        int PlayerHP = hpcomp.HP; //PlayerHP内の変数HPをPlayerHPとして使用
        hpslider.value = PlayerHP; //Valueの値をPlayerHPの値にする
    }
}