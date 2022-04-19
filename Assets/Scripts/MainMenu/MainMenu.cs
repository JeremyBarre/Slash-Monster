using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Toutes les boucles qui permets aux boutons des menus différents de changer de menu etc..
    public string levelToLoad;

    public GameObject settingWindow;
    public GameObject playMenu;
    public GameObject bestiary;
    public GameObject armory;

    public void StartGame()
    {
        SceneManager.LoadScene (levelToLoad);
    }
    public void QuitGame()
    {
        Application.Quit();
    }


    public void PlayMenu()
    {
        playMenu.SetActive(true);
    }
    public void ClosePlayMenu()
    {
        playMenu.SetActive(false);
    }

    public void Bestiary()
    {
        bestiary.SetActive(true);
    }
    public void CloseBestiary()
    {
        bestiary.SetActive(false);
    }


    public void SettingMenu()
    {
        settingWindow.SetActive(true);
    }
    public void CloseSettingMenu()
    {
        settingWindow.SetActive(false);
    }

    public void Armory()
    {
        armory.SetActive(true);
    }
    public void CloseArmory()
    {
        armory.SetActive(false);
    }

    
    

    

}
