using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{

    [SerializeField]  RectTransform fader;

    // Start is called before the first frame update
    /*
    private void Start()
    {
        fader.gameObject.SetActive (true);

        LeanTween.alpha (fader, 1, 0);
        LeanTween.alpha (fader, 0, 0.5f).setOnComplete(() => {
            fader.gameObject.SetActive (false);
        });
    }
    */

    // Update is called once per frame
    public void OpenNextScene () {
        fader.gameObject.SetActive (true);

        //LeanTween.alpha (fader, 1, 0);
        LeanTween.alpha (fader, 1, 0.5f).setOnComplete(() => {
            SceneManager.LoadScene("GameScene 1");
        });
    }
}
