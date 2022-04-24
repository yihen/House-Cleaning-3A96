using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisiondisappear : MonoBehaviour
{

    [SerializeField] public GameObject fumes;
    [SerializeField] public GameObject fumes1;
    [SerializeField] public GameObject fumes2;
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name == "fire ps"){
            Debug.Log("collided");
            Destroy (col.gameObject);
            fumes.SetActive(true);
            StartCoroutine (stopFumes ());
        }

        else if(col.gameObject.name == "fire ps 2")
        {
            Debug.Log("collided");
            Destroy (col.gameObject);
            fumes1.SetActive(true);
            StartCoroutine (stopFumes1 ());
        }

        else if(col.gameObject.name == "fire ps 3")
        {
            Debug.Log("collided");
            Destroy (col.gameObject);
            fumes2.SetActive(true);
            StartCoroutine (stopFumes2 ());
        }
    }

    IEnumerator stopFumes() 
    {
        yield return new WaitForSeconds (3.0f);
        fumes.SetActive(false);
    }

    IEnumerator stopFumes1() 
    {
        yield return new WaitForSeconds (3.0f);
        fumes1.SetActive(false);
    }
    IEnumerator stopFumes2() 
    {
        yield return new WaitForSeconds (3.0f);
        fumes2.SetActive(false);
    }
}
