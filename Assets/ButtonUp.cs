using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUp : MonoBehaviour {
    
    [SerializeField]
    private float speed = 10.0f;
    [SerializeField]
    private MoveGun GetMoveGun;

	// Use this for initialization
	void Start () {
		
	}

    public void OnClick()
    {
        if (transform.position.y >= 18.0f)
            return;
        transform.position += transform.up * speed * Time.deltaTime;
        Debug.Log("Button click!");
    }

	// Update is called once per frame
	void Update () {
        
	}
}
