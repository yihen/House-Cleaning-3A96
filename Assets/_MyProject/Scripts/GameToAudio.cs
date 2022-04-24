using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameToAudio : MonoBehaviour
{
    // Start is called before the first frame update
   public void GameToSettings()
    {
        SceneManager.LoadScene("TrySettings");
    }
}
