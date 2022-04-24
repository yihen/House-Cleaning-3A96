using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wingame : MonoBehaviour
{
    public GameObject BoxZone1;
    public GameObject BoxZone2;
    public GameObject BoxZone3;
    [SerializeField]  RectTransform fader;

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
        if(
           GameObject.Find("SPWater1") == null && 
           GameObject.Find("SPWater2") == null &&
           GameObject.Find("SPWater3") == null &&
           GameObject.Find("SPWater4") == null &&
           FirstZoneScript.boxes == 1 &&
           SecondZoneScript.boxes == 1 &&
           ThirdZoneScript.boxes == 1 &&
           GameObject.Find("fire ps") == null && 
           GameObject.Find("fire ps 2") == null &&
           GameObject.Find("fire ps 3") == null
          )   
        {
        fader.gameObject.SetActive (true);

        //LeanTween.alpha (fader, 1, 0);
        LeanTween.alpha (fader, 1, 0.5f).setOnComplete(() => {
            SceneManager.LoadScene("WinMenu 1");
        });
        } 
    }
}
