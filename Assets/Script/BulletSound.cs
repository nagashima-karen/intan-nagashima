using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSound : MonoBehaviour {

    [SerializeField]
    private AudioSource audioSource = null;

	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
            audioSource.Play();	
	}
}
