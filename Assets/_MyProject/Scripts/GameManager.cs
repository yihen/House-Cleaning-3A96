using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    public GameObject YouLose;
    public GameObject YouWin;
    public GameObject Objectives;
    public float resetDelay;

    void Awake()
    {
        if(instance == null)
            instance = this;
        else if (instance != null)
            Destroy (gameObject);
    }

    public void Win()
    {
        //display a win Message
        YouWin.SetActive(true);
        Objectives.SetActive(false);
        //Time.timeScale = .5f;
        //Invoke ("Reset", resetDelay);
    }

    public void Lose()
    {
        //display a lose Message
        YouLose.SetActive(true);
        Objectives.SetActive(false);
        Time.timeScale = .5f;
        //Invoke ("Reset", resetDelay);
    }

    void Reset()
    {
        Time.timeScale = 1.0f;
        //Application.LoadLevel (Application.loadedLevel);
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }
}
