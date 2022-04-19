using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrouchScript : MonoBehaviour
{

    // établissement de/des variables
    CharacterController playerCol;
    float originalHeight;
    public float reducedHeight;


    // plusieurs boucles pour que le personnage s'accroupis

    void Start()
    {
        playerCol = GetComponent<CharacterController>();
        originalHeight = playerCol.height;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Accroupir"))
            crouch();
        else if (Input.GetButtonUp("Accroupir"))
            GoUp();

    }
    void crouch()
    {
        playerCol.height = reducedHeight;
    }

    void GoUp()
    {
        playerCol.height = originalHeight;
    }
}
