using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreShow : MonoBehaviour
{
    [SerializeField] string levelName;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Text>().text = "Highscore: " + PlayerPrefs.GetFloat(levelName).ToString("0.00");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
