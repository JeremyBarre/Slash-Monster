using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// C'est le script concernant l'ennemi

public class Player : MonoBehaviour
{
    // établissement de/des variables

    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;
    public bool attack = false;

    public Transform target;
    public float speed = 0f;
    Rigidbody rig;
    public bool start = true;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        rig = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (currentHealth < 0)
        {
            SceneManager.LoadScene("Victory");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

        }
    }

    
// Programme qui détecte si l'épée fais son animation + entre en contact avec le joueur

    private void OnTriggerEnter(Collider other)
    {
        start = false;
        if (attack == true)
        {
            if (other.tag == "Hit1"){
                TakeDamage(10);
            }
        }

    }
    
// programme qui actualise les dégâts

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
}