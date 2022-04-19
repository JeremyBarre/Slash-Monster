using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsMenu : MonoBehaviour
{
      public GameObject weapons;
      public GameObject armor;


      public GameObject swordShield;
      public GameObject twoHandedWeapons;
      public GameObject rangedWeapons;

      public GameObject lightArmor;
      public GameObject mediumArmor;
      public GameObject heavyArmor;


    public void SettingWeapons() {
        weapons.SetActive(true);
    }
    public void CloseSettingWeapons(){
        weapons.SetActive(false);
    }

    public void SettingArmor() {
        armor.SetActive(true);
    }
    public void CloseSettingArmor(){
        armor.SetActive(false);
    }



    public void SettingSword()
    {
        swordShield.SetActive(true);
    }

    public void CloseSettingSword()
    {
        swordShield.SetActive(false);
    }

    public void SettingTwoHanded()
    {
        twoHandedWeapons.SetActive(true);
    }

    public void CloseSettingTwoHanded()
    {
        twoHandedWeapons.SetActive(false);
    }

    public void SettingRanged()
    {
        rangedWeapons.SetActive(true);
    }

    public void CloseSettingRanged()
    {
        rangedWeapons.SetActive(false);
    }




    public void SettingLight()
    {
        lightArmor.SetActive(true);
    }

    public void CloseSettingLight()
    {
        lightArmor.SetActive(false);
    }

    public void SettingMedium()
    {
        mediumArmor.SetActive(true);
    }

    public void CloseSettingMedium()
    {
        mediumArmor.SetActive(false);
    }

    public void SettingHeavy()
    {
        heavyArmor.SetActive(true);
    }

    public void CloseSettingHeavy()
    {
        heavyArmor.SetActive(false);
    }
}
