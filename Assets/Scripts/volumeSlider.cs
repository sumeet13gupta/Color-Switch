using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class volumeSlider : MonoBehaviour
{
    [SerializeField] Slider vol;
    void Start()
    {
        if (!PlayerPrefs.HasKey("musicVolume")) 
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }
        else
        {
            Load();
        }
    }
    public void Load()
    {
        vol.value = PlayerPrefs.GetFloat("musicVolume");
    }
    public void ChangeVolume()
    {
        AudioListener.volume = vol.value;
    }
    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", vol.value);
    }
}

