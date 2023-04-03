using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishScript : MonoBehaviour
{
    int finished;
    string lastLevel;
    string lastScene;
    float time;
    float highTime;
    public Text finishText;
    public Text spendTime;
    public Text highScore;

    string retryWhat;
    // Start is called before the first frame update
    void Start()
    {
        lastLevel = PlayerPrefs.GetString("lastLevel");
        finished = PlayerPrefs.GetInt("finishedLevel");
        lastScene = PlayerPrefs.GetString("finishedScene");
        if (lastLevel == "NotAssigned")
        {
            highTime = 0;
            time = 0;
            retryWhat = "Menu";
        }
        else
        {
            highTime = PlayerPrefs.GetFloat(lastLevel);
            time = PlayerPrefs.GetFloat("TempTime");
            retryWhat = lastScene;

        }

        if (finished == 1)
        {
            finishText.text = "Level Finished!";
            spendTime.text = "Finished At: " + time.ToString("0.00");
            highScore.text = "High Score: " + highTime.ToString("0.00");
        }
        else
        {
            finishText.text = "Level Failed!";
            spendTime.text = "Failed At: " + time.ToString("0.00");
            highScore.text = "High Score: " + highTime.ToString("0.00");
        }

        lastLevel = "NotAssigned";
        
    }
    public void RetryButton()
    {
        SceneManager.LoadScene(lastScene);
    }
}
