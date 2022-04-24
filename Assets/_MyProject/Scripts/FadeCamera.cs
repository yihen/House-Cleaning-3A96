using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using DentedPixel;
//using UnityEngine.UI;

public class FadeCamera : MonoBehaviour
{
    #region Variables

    [SerializeField] private RectTransform _fadeScreenTransform;

    [Header("Fade Settings")]
    
    [SerializeField] [Range(0.1f, 3.0f)] private float _fadeInTime = 1.0f;
    /*
    [SerializeField] [Range(0.1f, 3.0f)] private float _fadeOutTime = 1.0f;
    */

    #endregion

    
    #region Unity Methods

    protected void Start()
    {
        var seq = LeanTween.sequence();
        
        seq.append(1f);
        seq.append( () => {
            FadeInCam();
        });
        /*
        seq.append(6f);
        seq.append( () => {
            FadeOutCam();
        });
        */
    }

    #endregion


    #region Own Methods

    
    public void FadeInCam()
    {
        LeanTween.alpha(_fadeScreenTransform, to:0f, _fadeInTime);
    }
    
    /*
    public void FadeOutCam()
    {
        LeanTween.alpha(_fadeScreenTransform, to:1f, _fadeOutTime);
    }
    */

    #endregion
}
