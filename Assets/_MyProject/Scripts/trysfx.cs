using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class trysfx : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ObjectMusic;
    public Slider volumeSlider;

    private float MusicVolume = 1f;
    private AudioSource AudioSource;
    private void Start()
    {
        ObjectMusic = GameObject.FindWithTag("SFXMusic");
        AudioSource = ObjectMusic.GetComponent<AudioSource>();

        MusicVolume = PlayerPrefs.GetFloat("volume");
        AudioSource.volume = MusicVolume;
        volumeSlider.value = MusicVolume;
    }

    // Update is called once per frame
    private void Update()
    {
        AudioSource.volume = MusicVolume;
        PlayerPrefs.SetFloat("volume", MusicVolume);
    }

    public void updateVolume(float volume)
    {
        MusicVolume = volume;
    }
}
