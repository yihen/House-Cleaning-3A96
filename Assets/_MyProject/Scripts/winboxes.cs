using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winboxes : MonoBehaviour
{

    public GameObject BoxZone1;
    public GameObject BoxZone2;
    public GameObject BoxZone3;

    private BoxEvent FirstZoneScript;
    private BoxEvent1 SecondZoneScript;
    private BoxEvent2 ThirdZoneScript;
    // Start is called before the first frame update
    void Start()
    {
        FirstZoneScript = BoxZone1.GetComponent<BoxEvent>();
        SecondZoneScript = BoxZone2.GetComponent<BoxEvent1>();
        ThirdZoneScript = BoxZone3.GetComponent<BoxEvent2>();
    }

    // Update is called once per frame
    void Update()
    {
        if (FirstZoneScript.boxes == 1 &&
            SecondZoneScript.boxes == 1 &&
            ThirdZoneScript.boxes == 1)
        {
            GameManager.instance.Lose ();
        }
    }
}
