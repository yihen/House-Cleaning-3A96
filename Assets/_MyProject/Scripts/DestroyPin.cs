using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPin : MonoBehaviour
{
    public GameObject Pin;
     void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.name == "FirePin_c")
        {
            Debug.Log("collided");
            Destroy (Pin);
        }
    }
}
