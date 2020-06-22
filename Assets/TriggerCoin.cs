using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerCoin : MonoBehaviour
{
   
    void Start()
    {
        Collider2D c;
        if (!GetComponent<Collider2D>())
        {
            c = gameObject.AddComponent<BoxCollider2D>();  
		}
        else
        {
            c = GetComponent<Collider2D>();
		}
        c.isTrigger = true;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Text txt;
        txt = GameObject.Find ("/Canvas/TextScore").GetComponent<Text>();
        ScoreManager.nScore++;
        txt.text = "Score : " + ScoreManager.nScore;
        Destroy (gameObject);
    }
}
