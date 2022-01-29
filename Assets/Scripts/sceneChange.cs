using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void quitGame()
    {
        Application.Quit();
    }
    public void startGame()
    {
        SceneManager.LoadScene("MainGame");
    }
    public void halpPlz()
    {
        SceneManager.LoadScene("halp");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
