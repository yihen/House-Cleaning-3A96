using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using DentedPixel;
//using UnityEngine.UI;

public class SplashMenuLT : MonoBehaviour
{
    #region Variables

    [SerializeField] private GameObject _splashScr;

    [Header("SplashScreen Settings")]

    [Header("Decal on Floor")]
    [SerializeField] private GameObject _decalJetHammer;
    [SerializeField] private CanvasGroup _mainMenuPanel;
    private RectTransform _splashScrRectTransform;

    #endregion

    #region Unity Methods
    protected void Awake()
    {
        _splashScr.transform.localScale = new Vector3(x: 0.8f, y: 0.8f, z: 1.0f);
        _splashScrRectTransform = _splashScr.GetComponent<RectTransform>();
    }

    
    protected void Start ()
    {
        var seq = LeanTween.sequence();
        seq.append(3f);
        seq.append( () => {
            FadeInLogo();
        });
        seq.append(3f);
        seq.append ( () => {
           FadeOutLogo(); 
        });
        seq.append(1f);
        seq.append( () => {
            ShowDecalAndMenu();
        });
    }
    
    #endregion

    #region Own Methods

    private void FadeInLogo()
    {
        LeanTween.scaleX(_splashScr, to: 1.2f, time: 1f);
        LeanTween.scaleY(_splashScr, to: 1.2f, time: 1f);
        LeanTween.alpha(_splashScr, to: 1f, time: 1f);
    }

    private void FadeOutLogo()
    {
        LeanTween.scaleX(_splashScr, to: 0, time: 1f);
        LeanTween.scaleY(_splashScr, to: 0.8f, time: 1f);
        LeanTween.alpha(_splashScr, to: 0f, time: 1f);
    }

    private void ShowDecalAndMenu()
    {
        _decalJetHammer.SetActive(true);
        LeanTween.alphaCanvas(_mainMenuPanel, to: 1f, time: 1.0f);
    }

    #endregion
}
