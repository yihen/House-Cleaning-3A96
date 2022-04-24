using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
 // for timing
 public float timer = 240f;
 public Text timerSeconds;


 // Use this for initialization
 void Start () 
 {
  timerSeconds = GetComponent<Text> ();
 }
 
 // Update is called once per frame
 void Update () 
 {
  timer -= Time.deltaTime;
  timerSeconds.text = timer.ToString("f0");
  if (timer <= 0) 
  {
        SceneManager.LoadScene("LoseMenu 1");
  }

 }
}
