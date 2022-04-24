using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprayParticles : MonoBehaviour
{
    [SerializeField] private ParticleSystem steam;
    [SerializeField] private AudioSource audioSource;
    public GameObject Pin;

    public void StartSteam()
    {
        if (!Pin) {
            //activate steam by changing the playback speed to 1
            steam.gameObject.SetActive(true);
            steam.Emit(1);
            audioSource.Play();
        }
    }
    public void StopSteam()
    {
        //deactivate steam by changing the playback speed to 0 
        steam.Emit(0);
        steam.gameObject.SetActive(false);
    }
}
