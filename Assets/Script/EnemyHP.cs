using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHP : MonoBehaviour
{
    [SerializeField]
    private readonly int maxHP = 1000;    //体力の最大値
    public int HP;    //体力
    [SerializeField]
    private int PlayerATK = 10;  //プレイヤーの攻撃力
    [SerializeField]
    private Animator animator;
    [SerializeField]
    private ParticleSystem particle;

    void Start()
    {
        HP = maxHP; //初期体力を最大値にする
    }


    void Update()
    {
        //引数0はLayerのdefault。
        //上から順番の0,1,2,3.....のように割り当てられます。
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
        if (stateInfo.nameHash == Animator.StringToHash("Base Layer.Idle01 0 0 0 0"))
        {
            particle.Play(); //パーティクルの再生 
        }

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