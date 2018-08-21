using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{

    public GameObject HpBar1;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {

        //  on damage
        if (col.gameObject.tag == "Enemy")
        {
            HpBar1.gameObject.SendMessage("onDamage", 10);
        }
    }
}