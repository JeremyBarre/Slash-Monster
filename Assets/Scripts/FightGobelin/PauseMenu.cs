using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    
    public string levelToLoad;
    public GameObject settingWindow;

    // Update is called once per frame
    void Update()
    {
        //fonction mettant en place la pause attribuant la touche echap
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();

            } else {

                Pause();
            }
        }
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;

        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void SettingButton()
    {
        settingWindow.SetActive(true);
    }

    public void CloseSettingWindow()
    {
        settingWindow.SetActive(false);
        
    }
    public void QuitGame()
    {
        Resume();
        SceneManager.LoadScene(levelToLoad);
        Cursor.visible = true;
        
    }
}
