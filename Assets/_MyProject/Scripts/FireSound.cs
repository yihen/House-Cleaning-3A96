using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSound : MonoBehaviour
{
    //Play Sound
    // Start is called before the first frame update
    void Start()
    {
        AudioManager.instance.PlaySound("Fire", transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
