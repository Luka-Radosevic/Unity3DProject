using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public Dropdown graphicsDrop, resolutionDrop;
    public Slider volumeSlider;
    public Toggle grainToggle, chromaticToggle, motionToggle, vignetteToggle;
    public bool inGame;
    public GameObject grainCam, chromaticCam, motionCam, vignetteCam;
    
    void Start()
    {
        if(PlayerPrefs.GetInt("settingsSaved", 0) == 0)
        {
            PlayerPrefs.SetInt("graphics", 0);
            PlayerPrefs.SetInt("resolution", 0);
            PlayerPrefs.SetFloat("volume", 1.0f);
            PlayerPrefs.SetInt("grain", 0);
            PlayerPrefs.SetInt("chromatic", 0);
            PlayerPrefs.SetInt("motion", 0);
            PlayerPrefs.SetInt("vignette", 0);
        }

        if(PlayerPrefs.GetInt("graphics", 2) == 2)
        {
            graphicsDrop.value = 0;
            QualitySettings.SetQualityLevel(0);
        }

        if(PlayerPrefs.GetInt("graphics", 1) == 1)
        {
            graphicsDrop.value = 1;
            QualitySettings.SetQualityLevel(1);
        }

        if(PlayerPrefs.GetInt("graphics", 0) == 0)
        {
            graphicsDrop.value = 2;
            QualitySettings.SetQualityLevel(2);
        }



        if(PlayerPrefs.GetInt("resolution", 3) == 3)
        {
            resolutionDrop.value = 0;
            Screen.SetResolution(854, 480, true);
        }

        if(PlayerPrefs.GetInt("resolution", 2) == 2)
        {
            resolutionDrop.value = 1;
            Screen.SetResolution(1280, 720, true);
        }

        if(PlayerPrefs.GetInt("resolution", 1) == 1)
        {
            resolutionDrop.value = 2;
            Screen.SetResolution(1920, 1080, true);
        }

        if(PlayerPrefs.GetInt("resolution", 0) == 0)
        {
            resolutionDrop.value = 3;
            Screen.SetResolution(2560, 1440, true);
        }


        volumeSlider.value = PlayerPrefs.GetFloat("volume");
        AudioListener.volume = PlayerPrefs.GetFloat("volume");

        if(PlayerPrefs.GetInt("grain", 1) == 1)
        {
            grainToggle.isOn = false;
            if(inGame == true)
            {
                grainCam.SetActive(false);
            }
        }

        if(PlayerPrefs.GetInt("grain", 0) == 0)
        {
            grainToggle.isOn = true;
            if(inGame == true)
            {
                grainCam.SetActive(true);
            }
        }

        if(PlayerPrefs.GetInt("chromatic", 1) == 1)
        {
            chromaticToggle.isOn = false;
            if(inGame == true)
            {
                chromaticCam.SetActive(false);
            }
        }

        if(PlayerPrefs.GetInt("chromatic", 0) == 0)
        {
            chromaticToggle.isOn = true;
            if(inGame == true)
            {
                chromaticCam.SetActive(true);
            }
        }

        if(PlayerPrefs.GetInt("motion", 1) == 1)
        {
            motionToggle.isOn = false;
            if(inGame == true)
            {
                motionCam.SetActive(false);
            }
        }

        if(PlayerPrefs.GetInt("motion", 0) == 0)
        {
            motionToggle.isOn = true;
            if(inGame == true)
            {
                motionCam.SetActive(true);
            }
        }

        if(PlayerPrefs.GetInt("vignette", 1) == 1)
        {
            vignetteToggle.isOn = false;
            if(inGame == true)
            {
                vignetteCam.SetActive(false);
            }
        }

        if(PlayerPrefs.GetInt("vignette", 0) == 0)
        {
            vignetteToggle.isOn = true;
            if(inGame == true)
            {
                vignetteCam.SetActive(true);
            }
        }
    }

    public void setGraphics()
        {
            if(graphicsDrop.value == 0)
            {
                PlayerPrefs.SetInt("graphics", 2);
                PlayerPrefs.Save();
                QualitySettings.SetQualityLevel(0);
            }

            if(graphicsDrop.value == 1)
            {
                PlayerPrefs.SetInt("graphics", 1);
                PlayerPrefs.Save();
                QualitySettings.SetQualityLevel(1);
            }

            if(graphicsDrop.value == 2)
            {
                PlayerPrefs.SetInt("graphics", 0);
                PlayerPrefs.Save();
                QualitySettings.SetQualityLevel(2);
            }
        }

        public void setResolution()
        {
            if(resolutionDrop.value == 0)
            {
                PlayerPrefs.SetInt("resolution", 3);
                PlayerPrefs.Save();
                Screen.SetResolution(854, 480, true);
                Debug.Log("480p set");
            }

            if(resolutionDrop.value == 1)
            {
                PlayerPrefs.SetInt("resolution", 2);
                PlayerPrefs.Save();
                Screen.SetResolution(1280, 720, true);
                Debug.Log("720p set");
            }

            if(resolutionDrop.value == 2)
            {
                PlayerPrefs.SetInt("resolution", 1);
                PlayerPrefs.Save();
                Screen.SetResolution(1920, 1080, true);
                Debug.Log("1080p set");
            }

            if(resolutionDrop.value == 3)
            {
                PlayerPrefs.SetInt("resolution", 0);
                PlayerPrefs.Save();
                Screen.SetResolution(2560, 1440, true);
                Debug.Log("1440p set");
            }
        }

        public void setVolume()
        {
            PlayerPrefs.SetFloat("volume", volumeSlider.value);
            PlayerPrefs.Save();
            AudioListener.volume = volumeSlider.value;
        }

        public void toggleGrain()
        {
            if(grainToggle.isOn == false)
            {
                PlayerPrefs.SetInt("grain", 1);
                PlayerPrefs.Save();
                if(inGame == true)
                {
                    grainCam.SetActive(false);
                }
            }

            if(grainToggle.isOn == true)
            {
                PlayerPrefs.SetInt("grain", 0);
                PlayerPrefs.Save();
                if(inGame == true)
                {
                    grainCam.SetActive(true);
                }
            }
        }

        public void toggleChromatic()
        {
            if(chromaticToggle.isOn == false)
            {
                PlayerPrefs.SetInt("chromatic", 1);
                PlayerPrefs.Save();
                if(inGame == true)
                {
                    chromaticCam.SetActive(false);
                }
            }

            if(chromaticToggle.isOn == true)
            {
                PlayerPrefs.SetInt("chromatic", 0);
                PlayerPrefs.Save();
                if(inGame == true)
                {
                    chromaticCam.SetActive(true);
                }
            }
        }

        public void toggleMotion()
        {
            if(motionToggle.isOn == false)
            {
                PlayerPrefs.SetInt("motion", 1);
                PlayerPrefs.Save();
                if(inGame == true)
                {
                    motionCam.SetActive(false);
                }
            }

            if(motionToggle.isOn == true)
            {
                PlayerPrefs.SetInt("motion", 0);
                PlayerPrefs.Save();
                if(inGame == true)
                {
                    motionCam.SetActive(true);
                }
            }
        }

        public void toggleVignette()
        {
            if(vignetteToggle.isOn == false)
            {
                PlayerPrefs.SetInt("vignette", 1);
                PlayerPrefs.Save();
                if(inGame == true)
                {
                    vignetteCam.SetActive(false);
                }
            }

            if(vignetteToggle.isOn == true)
            {
                PlayerPrefs.SetInt("vignette", 0);
                PlayerPrefs.Save();
                if(inGame == true)
                {
                    vignetteCam.SetActive(true);
                }
            }
        }

        public void saveSettings()
        {
            PlayerPrefs.SetInt("settingsSaved", 1);
            PlayerPrefs.Save();
        }
}
