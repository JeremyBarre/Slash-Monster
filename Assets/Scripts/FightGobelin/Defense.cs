using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defense : MonoBehaviour
{
    // établissement de/des variables

    Animator anim;

    // Ce programme permet juste de lancer l'animation de la défense (mouvement du bouclier)

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire2"))
            anim.SetBool("Defending", true);
        else if (Input.GetButtonUp("Fire2"))
            anim.SetBool("Defending", false);
    }
}
