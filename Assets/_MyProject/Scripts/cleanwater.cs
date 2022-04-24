using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cleanwater : MonoBehaviour
{
    public CleaningMech cleaningMech;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.name == "sponge_c" && cleaningMech.CleanScore == 1){
            cleaningMech.CleanScore = 0;
            Debug.Log("collided");
            Destroy (gameObject);
        }
    }
}
