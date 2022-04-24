using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
  // établissement de/des variables (programme du joueur)
  public int maxHealth = 100;
  public int currentHealth;

  public HealthBar healthBar;
  public bool defense = false;

  void Start()
  {
    currentHealth = maxHealth;
    healthBar.SetMaxHealth(maxHealth);
  }

  // conditions pour savoir si le joueur a perdu + s'il se défend pour ne pas prendre de dégâts
  void Update()
  {
    if (currentHealth < 0)
    {
      SceneManager.LoadScene("GameOver");
      Cursor.lockState = CursorLockMode.None;
      Cursor.visible = true;
    }
    if (Input.GetButtonDown("Fire2"))
    {
      defense = true;
    }
    else if (Input.GetButtonUp("Fire2"))
    {
      defense = false;
    }
  }

  // Programme pour le contact entre le joueur et le monstre

  private void OnTriggerEnter(Collider other)
  {
    if (defense == false)
    {
      if (other.tag == "Gobelin")
        TakeDamage(20);
    }
    if (defense == true)
    {
      if (other.tag == "Gobelin")
        TakeDamage(0);
    }
  }

  // programme qui actualise la barre de vie

  public void TakeDamage(int damage)
  {
    currentHealth -= damage;
    healthBar.SetHealth(currentHealth);
  }
}