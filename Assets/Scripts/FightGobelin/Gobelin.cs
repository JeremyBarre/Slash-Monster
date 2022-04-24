using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gobelin : MonoBehaviour
{
  public Transform target;
  public int maxHealth = 100;
  public int currentHealth;
  public float attackRepeatTime = 1;
  public HealthBar healthBar;
  private Animator anim;
  private float attackTime;
  public int Dammage;

  void Start()
  {
    anim = gameObject.GetComponent<Animator>();
    currentHealth = maxHealth;
    healthBar.SetMaxHealth(maxHealth);
    attackTime = Time.time;
  }

  void Update()
  {

    target = GameObject.FindGameObjectWithTag("Player").transform;
    attack();
    if (currentHealth < 0)
    {
      SceneManager.LoadScene("Victory");
      Cursor.lockState = CursorLockMode.None;
      Cursor.visible = true;
    }
  }


  // Programme qui détecte si l'épée fais son animation + entre en contact avec le joueur

  //   private void OnTriggerEnter(Collider other)
  //   {
  //     if (attack == true)
  //     {
  //       if (other.tag == "Melee")
  //       {
  //         TakeDamage(10);
  //       }

  //     }
  //   }

  // programme qui actualise les dégâts

  void TakeDamage(int damage)
  {
    currentHealth -= damage;
    healthBar.SetHealth(currentHealth);

  }

  void attack()
  {
    if (Time.time > attackTime)
    {
      anim.Play("Attack");
      target.GetComponent<Player>().TakeDamage(Dammage);
      // Debug.Log("attack" + Dammage + "damage");
      attackTime = Time.time + attackRepeatTime;
    }
  }
}