using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControler : MonoBehaviour {
    
    [SerializeField]
    private float speed = 10.0f;
    [SerializeField]
    private GameObject player;
    bool pushUp = false;
    bool pushRight = false;
    bool pushLeft = false;
    bool pushDown = false;

    public void PushDownUp()
    {
        pushUp = true;
    }

    public void PushDownRight()
    {
        pushRight = true;
    }

    public void PushDownLeft()
    {
        pushLeft = true;
    }

    public void PushDownDown()
    {
        pushDown = true;
    }

    public void PushUpUp()
    {
        pushUp = false;
    }

    public void PushUpRight()
    {
        pushRight = false;
    }

    public void PushUpLeft()
    {
        pushLeft = false;
    }

    public void PushUpDown()
    {
        pushDown = false;
    }

	// Use this for initialization
	void Start () {
		
	}

    public void MoveUp()
    {
        if (player.transform.position.y >= 18.0f)
                return;
            player.transform.position += player.transform.up * speed * Time.deltaTime;
        Debug.Log("ButtonUp click!");
    }

    public void MoveRight()
    {
            if (player.transform.position.x >= 15.0f)
                return;
            player.transform.position += player.transform.right * speed * Time.deltaTime;
            Debug.Log("ButtonRight click!");
    }

    public void MoveLeft()
    {
            if (player.transform.position.x <= -15.0f)
                return;
            player.transform.position -= player.transform.right * speed * Time.deltaTime;
            Debug.Log("ButtonLeft click!");
    }

    public void MoveDown()
    {
            if (player.transform.position.y <= 5.0f)
                return;
            player.transform.position -= player.transform.up * speed * Time.deltaTime;
            Debug.Log("ButtonDown click!");
    }

	// Update is called once per frame
	void Update () {
        if (pushUp)
        {
            MoveUp();
        }
        if (pushRight)
        {
            MoveRight();
        }
        if (pushLeft)
        {
            MoveLeft();
        }
        if (pushDown)
        {
            MoveDown();
        }
	}
}
