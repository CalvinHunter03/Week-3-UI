using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{

    public AudioMixer audioMixer;

    public GameObject mainMenu, optionsMenu, creditsMenu;

    void Start(){
        TrueStart();
    }
    public void SetVolume (float volume){
        audioMixer.SetFloat("volume", volume);
    }

    public void SetQuality(int qualityIndex){
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    private void TrueStart(){
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
        creditsMenu.SetActive(false);
    }
    
}
