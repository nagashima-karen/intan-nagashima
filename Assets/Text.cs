using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    IEnumerator Fadeout()
    {
        for (float i = 0; i <= 20; i++)
        {
            GetComponent<TextMesh>().color = new Color(255, 255, 0, 1.0f - i / 20.0f);
            yield return null;
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(Fadeout());
        }
    }
}
