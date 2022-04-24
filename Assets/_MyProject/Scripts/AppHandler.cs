using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AppHandler : MonoBehaviour
{
    [SerializeField]  RectTransform fader;
    // Start is called before the first frame update
    public void QuitGame () {
        fader.gameObject.SetActive (true);

        //LeanTween.alpha (fader, 1, 0);
        LeanTween.alpha (fader, 1, 0.5f).setOnComplete(() => {
           #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
        });
    }
}
