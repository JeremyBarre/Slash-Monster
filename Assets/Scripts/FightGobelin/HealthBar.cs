using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    // établissement de/des variables

    public Slider slider;

    // Programme qui permet à la barre de vie d'être attribuer à des chiffres (pour connaître le nombre de point de vie du joueur et du monstre)
    
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(int health)
    {
        slider.value = health;
    }
}
