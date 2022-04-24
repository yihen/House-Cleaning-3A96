using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winfire : MonoBehaviour
{
    void Update()
    {
        if(
           GameObject.Find("fire") == null && 
           GameObject.Find("fire1") == null &&
           GameObject.Find("fire2") == null 
          )   
        {
            GameManager.instance.Lose ();
            //replace this with like a win or combine this with the other tasks and lead to the winning scene
        } 
    }
}
