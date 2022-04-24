using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

[RequireComponent(typeof (Slider))]
public class Sliders : MonoBehaviour
{
    Slider slider
    {
        get { return GetComponent<Slider>(); }
    }

    public AudioMixer mixer;
    [SerializeField]
    private string volumeName;
    [SerializeField]
    private Text volumeLabel;
    public void Start()
    {
        updateValueOnChange(slider.value);

        slider.onValueChanged.AddListener(delegate
        {
            updateValueOnChange(slider.value);
        });
    }
    public void updateValueOnChange(float value)
    {
        if (mixer != null)
            mixer.SetFloat(volumeName, Mathf.Log(value) * 20f);
        if (volumeLabel != null)
            volumeLabel.text = Mathf.Round(value * 100.0f).ToString() + "%";

    }
}
