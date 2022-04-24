using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class audiotomenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void AudioToMenu()
    {
        SceneManager.LoadScene("Menu 2");
    }
}
