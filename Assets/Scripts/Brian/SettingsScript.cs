using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsScript : MonoBehaviour
{
    bool defaultSettings;
    bool resetHighscore = false;
    [SerializeField] GameObject resetHighscoreBox;
    string[] allLevels = new string[] { "TESTLEVEL"};
    public Slider masterVolume;
    public Slider FOV;

    // Start is called before the first frame update
    void Start()
    {
        masterVolume.value = PlayerPrefs.GetFloat("masterVolume");
        FOV.value = PlayerPrefs.GetFloat("firstPersonFOV");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ApplyChangedSettings()
    {
        if (resetHighscoreBox.GetComponent<Toggle>().isOn == true)
        {
            for (int i = 0; i < allLevels.Length; i++)
            {
                PlayerPrefs.SetFloat(allLevels[i], 0.00f);
                Debug.Log(i);
            }
        }
        PlayerPrefs.SetFloat("masterVolume", masterVolume.value);
        PlayerPrefs.SetFloat("firstPersonFOV", FOV.value);
    }
}
