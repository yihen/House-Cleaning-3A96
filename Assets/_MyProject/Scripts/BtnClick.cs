using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnClick : MonoBehaviour
{
    [SerializeField]  RectTransform fader;
    // Start is called before the first frame update
    public void BtnNewScene()
    {
        fader.gameObject.SetActive (true);

        //LeanTween.alpha (fader, 1, 0);
    LeanTween.alpha (fader, 1, 0.5f).setOnComplete(() => {
        SceneManager.LoadScene("Menu 2");
    });
    }

}
