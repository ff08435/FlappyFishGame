using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoralScore : MonoBehaviour
{

 

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           
            ScoreScript.instance.UpdateScore();
        }
    }

}
