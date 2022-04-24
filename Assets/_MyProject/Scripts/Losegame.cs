using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseGame : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter()
    {
        //Trigger Lose Function

        GameManager.instance.Lose ();
        
    }
}
