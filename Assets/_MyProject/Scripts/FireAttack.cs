using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAttack : MonoBehaviour
{
    [SerializeField] private int dealDamageAmount = 10;
    float time = 0f;

    /*public void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.name == "Main Camera")
        {
            Debug.Log(Other.gameObject.name);
            // int Health = other.gameObject.GetComponent<Player>().currentHealth; 
            // Health -= dealDamageAmount;
            // healthBar.setHealth(Health);
            Health Health = Other.GetComponent<Health>();
            Debug.Log(dealDamageAmount);
            Health.TakeDamage(dealDamageAmount);
            //StartCouroutine(FireDamage());
        }
    }*/
    public void OnTriggerStay(Collider Other)
    {
        time += Time.deltaTime;
        if (time >= 1f)
        {
            time = time % 1f;
            if (Other.gameObject.name == "Main Camera")
            {
                Health Health = Other.GetComponent<Health>();
                Debug.Log(dealDamageAmount);
                Health.TakeDamage(dealDamageAmount);
                Debug.Log(time);
            }
        }
    }
    // IEnumerator FireDamage()
    // {
    //     yield return new WaitForSeconds(1);
    //     Health Health = Other.GetComponent<Health>();
    //     Health.TakeDamage(dealDamageAmount);
    // }

}
