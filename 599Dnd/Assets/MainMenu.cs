using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SceneSelection()
    {
        SceneManager.LoadScene("SelectionMenu");
    }

    public void ForestSelection()
    {
        SceneManager.LoadScene("ForestScene");
    }

    public void SnowSelection()
    {
        SceneManager.LoadScene("SnowScene");
    }

    public void SandSelection()
    {
        SceneManager.LoadScene("SandScene");
    }

    public void QuitGame()
    {
        Application.Quit();   
    }
}
