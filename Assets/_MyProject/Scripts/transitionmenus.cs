using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transitionmenus : MonoBehaviour
{
    [SerializeField] private CanvasGroup _mainMenuPanel;
    // Start is called before the first frame update
    protected void Start ()
    {
        var seq = LeanTween.sequence();
        seq.append(1f);
        seq.append( () => {
            ShowDecalAndMenu();
        });
    }

    // Update is called once per frame
    private void ShowDecalAndMenu()
    {
        
        LeanTween.alphaCanvas(_mainMenuPanel, to: 1f, time: 1.0f);
    }
}
