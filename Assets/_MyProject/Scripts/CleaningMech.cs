using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleaningMech : MonoBehaviour
{
    public int CleanScore = 1;

    void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.name == "sponge_c")
        {
            CleanScore = 1;
        }
    }
}
