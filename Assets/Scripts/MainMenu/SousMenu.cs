using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SousMenu : MonoBehaviour
{
      public GameObject settingManette;
      public GameObject settingJeu;
      public GameObject settingScreen;


        public void SettingManette()
    {
        settingManette.SetActive(true);
        settingJeu.SetActive(false);
    }

        public void ClosesettingManette()
    {
        settingManette.SetActive(false);
    }



        public void SettingJeu()
    {
        settingJeu.SetActive(true);
        settingManette.SetActive(false);
    }

        public void CloseSettingJeu()
    {
        settingJeu.SetActive(false);
    }



      public void SettingScreen()
    {
        settingScreen.SetActive(true);
    }

    public void CloseSettingScreen()
    {
        settingScreen.SetActive(false);
    }
}
