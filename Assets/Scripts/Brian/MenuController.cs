using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    //string goToMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void goTo(string goToMenu)
    {
        if (goToMenu != "Quit")
        {
            SceneManager.LoadScene(goToMenu);
        }
        else
        {
            Debug.Log("quit");
            Application.Quit();
        }
    }
}
