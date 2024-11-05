using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{

    public AudioMixer audioMixer;

    public GameObject mainMenu, optionsMenu, creditsMenu;

    public GameObject sliderFill;


    public static int colorPicker = 0;

    void Start()
    {
        TrueStart();
    }
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    private void TrueStart()
    {
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
        creditsMenu.SetActive(false);
    }

    public void SetColor(float colorScale)
    {
        if (colorScale >= 33 && colorScale < 66)
        {
            colorPicker = 1;
            sliderFill.GetComponent<Image>().color = new Color(1, 0, 0);
        }
        else if (colorScale >= 66)
        {
            colorPicker = 2;
            sliderFill.GetComponent<Image>().color = new Color(0, 1, 0);
        }
        else if (colorScale < 33)
        {
            colorPicker = 0;
            sliderFill.GetComponent<Image>().color = new Color(0, 0, 1);
        }

    }


}
