using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireHealth : MonoBehaviour
{
    public GameObject healthBarUI;
    public Slider health;

    bool regen = true;
    // Start is called before the first frame update
    void Start()
    {
        health.value = 40;
    }

    // Update is called once per frame
    void Update()
    {

        if(health.value <= 0)
        {
            Destroy(gameObject);
        }

        if(health.value > 100)
        {
            health.value = 100;
        }
        
        if(health.value < 100)
        {
            if(regen){
            StartCoroutine(WaitForSeconds());
            }
        }
    }

    void OnTriggerStay(Collider collider)
    {

        if (collider.gameObject.tag == "extinguishliquid")
        {
            health.value -= 10;
        }
    }

    IEnumerator WaitForSeconds()
    {
        regen = false;
        yield return new WaitForSecondsRealtime(3);
        health.value += 5;
        regen = true;
    }
}
