using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vitals : MonoBehaviour
{
    [SerializeField]
    private EnemyHP enemyHP;
    [SerializeField]
    private int damage;  //プレイヤーの攻撃力
    [SerializeField]
    private GameObject text;

    void Start()
    {
        text.GetComponent<TextMesh>().color = new Color(255, 255, 0, 0);
    }

    void OnTriggerEnter(Collider hit)
    {
        if (hit.CompareTag("Bullet"))
        {
            enemyHP.HP -= damage; //攻撃で体力が減少
            Debug.Log("急所に当たった!!" + enemyHP);

            StartCoroutine(Fadeout());

        }
    }

    IEnumerator Fadeout()
    {
        for (float i = 0; i <= 20; i++)
        {
            text.GetComponent<TextMesh>().color = new Color(255, 255, 0, 1.0f - i / 20.0f);
            yield return null;
        }
    }
}